using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits + entry) < (1 + entry)) || !((hits + 0) != (entry & 63)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound < 18.0)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel window samples are out of range.</summary>
        public static long AuditChannelWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-812) - entry) > (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
