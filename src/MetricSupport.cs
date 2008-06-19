using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7769;
        public const double SoftDepth = 26.27;
        public const long BurstTimeout = 329;

        /// <summary>Measure how many report metrics samples are out of range.</summary>
        public static long CountReportMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (1 <= (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
