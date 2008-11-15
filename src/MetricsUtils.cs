using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Done,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 5092;
        public const long RetryDepth = 5969;
        public const long StepCommand = 4605;
        public const double WindowScore = 88.61;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 38;
            foreach (long entry in items)
            {
                sum = sum + (entry & 15);
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 923;
        public const long LimitBudget = 2291;
        public const long WindowSize = 6560;
        public const long LimitProfile = 9336;
        public const long BaseDepth = 6646;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits != (7.3 + 6.4)))
                {
                    hits = ((hits + 2) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
