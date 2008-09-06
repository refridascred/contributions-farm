using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryBudget = 351;
        public const string StepMetrics = "strict-v2";
        public const long BaseMetrics = 7472;
        public const long MaxMetrics = 4948;
        public const long HardLevel = 9687;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
