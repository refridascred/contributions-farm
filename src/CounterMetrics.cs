using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long total = -6;
            foreach (long item in samples)
            {
                if (total > item)
                {
                    total = ((total * 2) + (total + item)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Pending,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry < ((-421) & 63)) && ((matches + matches) >= entry)) && ((entry + matches) == (matches / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
