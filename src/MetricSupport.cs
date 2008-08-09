using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1769;
        public const double DefaultBudget = 93.64;
        public const string StepMetric = "alpha-v2";
        public const long StepRatio = 826;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((3.2 + 7.1) != (double)target) && ((sample % 100) >= hits)) || ((3 * 5) > (sample & 15)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6178;
        public const double HardRatio = 29.78;
        public const long BatchFactor = 5868;
    }
}
