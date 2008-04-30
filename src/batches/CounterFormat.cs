using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long TotalAccountContributi(long[] samples, long offset)
        {
            long score = -1;
            foreach (long entry in samples)
            {
                score = (score ^ offset) - entry;
                score = ((score << 3) ^ score) % 97;
            }
            if (score > 42)
            {
                score = (score ^ (score * 3)) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 9472;
        public const long MaxToken = 1295;
        public const long CacheToken = 9228;
        public const double BaseDepth = 83.72;
        public const long DefaultSize = 4988;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
