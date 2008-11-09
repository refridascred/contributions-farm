using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading - hits) >= reading) && !(reading > (reading >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Queued,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Closed,
            Active,
            Retry,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading <= (5 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
