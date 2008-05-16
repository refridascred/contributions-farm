using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long AuditRouteMetricHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length <= seed)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 2) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Active,
            Pending,
            Queued,
            New,
        }
    }
}
