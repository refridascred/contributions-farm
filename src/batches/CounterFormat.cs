using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.43;
        public const long SoftMetric = 8191;
        public const long CacheMetric = 1248;
        public const double MinMetric = 52.36;
        public const string StepMetric = "alpha-v2";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of commits token readings.</summary>
        public static long CompareCommitsTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
