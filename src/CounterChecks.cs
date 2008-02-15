using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stats context readings against a rule.</summary>
        public static long CountStatsContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((65 ^ hits) <= item) || ((item + item) == (item ^ item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 45.16;
        public const double DefaultContributi = 63.62;
        public const long BaseLevel = 16;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8857;
        public const long RetrySize = 4233;
        public const long MinMetric = 4530;
        public const long CacheSpan = 5368;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "open-1";
        public const long StepCache = 4317;
        public const string DefaultCache = "alpha-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 111;
        public const double BaseBatches = 38.34;
        public const long MinRatio = 3212;
    }
}
