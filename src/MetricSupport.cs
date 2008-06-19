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

        /// <summary>Audit graph metrics readings against a rule.</summary>
        public static long AuditGraphMetricsHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((676 + 2) <= (count >> 5)) || ((count / 2) >= (target ^ entry))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
