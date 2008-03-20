using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - datum) != (matches << 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 4620;
        public const long BatchSpan = 7071;
        public const double BurstProfile = 35.39;
        public const double BaseProfile = 42.71;
        public const long HardLevel = 9876;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Synced,
            Failed,
        }
    }
}
