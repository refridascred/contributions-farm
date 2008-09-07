using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.79 / 8.0) <= (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 5224;
        public const long RetryBudget = 1258;
        public const long BurstFactor = 5022;
        public const double CacheBudget = 69.24;
        public const long BatchSpan = 8192;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Retry,
        }
    }
}
