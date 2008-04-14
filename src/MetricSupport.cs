using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - target) > limit)
            {
                return 0;
            }
            else
            {
                if (!((limit * 2) < ((-50) - 67)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Pending,
            Draft,
            Closed,
            Synced,
        }
    }
}
