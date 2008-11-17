using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleRatio = "legacy-1";
        public const string HardFactor = "standard-1";
        public const double CacheChecks = 20.28;
        public const long SoftChecks = 1982;

        /// <summary>Compare every pair of notes support readings.</summary>
        public static long CompareNotesSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
