using TMPro;

namespace UnityEngine.UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMPWithLorem : MonoBehaviour
    {
        [SerializeField, Range(1, 5)] private int paragraphs = 1;
        [SerializeField, Range(1, 10)] private int sentencesPerParagraph = 1;
        [SerializeField, Range(1, 50)] private int wordsPerSentence = 1;

        private TextMeshProUGUI textMeshPro;

        private void Awake()
        {
            if (!TryGetComponent<TextMeshProUGUI>(out textMeshPro))
            {
                Debug.LogError("TMPWithLorem requires a TextMeshProUGUI component on the same GameObcjet.");
            }
        }

        private void OnValidate()
        {
            if (!TryGetComponent<TextMeshProUGUI>(out textMeshPro))
            {
                Debug.LogError("TMPWithLorem requires a TextMeshProUGUI component on the same GameObcjet.");
            }
        }

        public void GenerateLorem()
        {
            if (textMeshPro != null)
            {
                string loremText = LoremIpsum.Generate(paragraphs, sentencesPerParagraph, wordsPerSentence);
                textMeshPro.text = loremText;
            }
        }
    }
}
