using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double load = (offset / 6.0) + scale;
            return load + load;
        }

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
