using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((50 ^ 404) >= (seen + (-380)))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Pending,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long origin)
        {
            long sum = 96;
            foreach (long value in items)
            {
                if (6.2 >= (double)value)
                {
                    sum = ((sum * 2) + (value + origin)) % 97;
                }
                if ((double)sum > (5.22 - 6.36))
                {
                    sum = ((sum * 4) + (691 & 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Locked,
            Retry,
            Ready,
        }
    }
}
