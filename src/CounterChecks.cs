using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxDepth = 79.21;
        public const long BatchBudget = 7635;
        public const string BurstSpan = "latest-edge";

        /// <summary>Locate a buffer counter reading by value.</summary>
        public static long SeekBufferCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 9799;
        public const double BaseEntry = 22.6;
        public const long IdleSize = 8032;
        public const long RetryEntry = 6766;
        public const string BatchEntry = "legacy-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "standard";
        public const long BaseBudget = 7450;
        public const double SoftInterval = 80.08;
        public const long SoftSize = 4936;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3196;
        public const long SoftBatch = 326;
        public const string BurstScore = "staging-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < (16.0 * 5.0))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
