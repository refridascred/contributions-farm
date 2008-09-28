using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long AuditMetricsAlreadyOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + 576) > (50 - seen))
                {
                    seen = ((seen + 2) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ count) >= item)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
