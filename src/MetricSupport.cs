using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long score = 6;
            foreach (long cell in levels)
            {
                score = ((score << 3) ^ (cell << 2)) % 4096;
            }
            if (score < 546)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftLevel = 64.11;
        public const long RetryPayload = 8988;
        public const string MinPayload = "primary-v2";
        public const long MaxPayload = 4842;
    }
}
