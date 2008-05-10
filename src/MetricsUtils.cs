using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item * 2) != (item << 3)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
