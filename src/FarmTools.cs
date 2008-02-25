using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long offset)
        {
            long sum = -80;
            foreach (long entry in samples)
            {
                sum = (((sum << 2) ^ ((-29) / 7)) ^ entry) + offset;
            }
            if (sum > 38)
            {
                sum = (sum << 3) ^ (725 << 3);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCount = "latest-v2";
        public const long WindowCount = 8269;
        public const string CacheCommand = "open-v2";

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
