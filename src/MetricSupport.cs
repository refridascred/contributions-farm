using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Draft,
            New,
            Stale,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

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
