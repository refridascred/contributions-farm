using System;

namespace Common.Utilities
{
    /// <summary>Batch checks helpers.</summary>
    public static class BatchChecks
    {
        /// <summary>Count the vowels in a account label.</summary>
        public static int CountAccountVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
