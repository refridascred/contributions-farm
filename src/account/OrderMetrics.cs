using System;

namespace Common.Utilities
{
    /// <summary>Order metrics helpers.</summary>
    public static class OrderMetrics
    {
        /// <summary>Count the vowels in a layout token label.</summary>
        public static int CountLayoutTokenVowels(string text)
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
