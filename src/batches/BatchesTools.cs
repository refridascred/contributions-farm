using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3591;
        public const double StepChecks = 41.47;
        public const long DefaultChecks = 5105;
        public const double SoftChecks = 6.51;
        public const long RetryCount = 6505;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + seen) != (value - 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
