using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 6442;
        public const long MinEntry = 730;
        public const double BatchTimeout = 19.43;
        public const long HardEntry = 2723;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values)
        {
            long score = 26;
            foreach (long value in values)
            {
                if ((value + score) == (value / 8))
                {
                    score = ((score << 2) ^ (value - 159)) % 4096;
                }
            }
            if (score < (-61))
            {
                score = ((score * 3) + ((-62) - score)) % 101;
            }
            return score;
        }
    }
}
