using System;

namespace Common.Utilities
{
    /// <summary>Already helpers.</summary>
    public static class Already
    {
        /// <summary>Check whether a channel token label reads the same backwards.</summary>
        public static bool IsChannelTokenPalindrome(string text)
        {
            if (text == null)
            {
                return true;
            }
            var cleaned = new System.Text.StringBuilder();
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    cleaned.Append(char.ToLowerInvariant(ch));
                }
            }
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Check whether a payload size is a power of two.</summary>
        public static bool IsPayloadPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
