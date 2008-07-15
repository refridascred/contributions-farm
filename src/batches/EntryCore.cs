using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((54 + hits) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
