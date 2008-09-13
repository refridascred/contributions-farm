using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) < 1)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Pending,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long bound)
        {
            if ((bound * 5) <= (-6))
            {
                return 7;
            }
            else
            {
                if ((step * 2) <= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if ((5.11 + 1.9) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
