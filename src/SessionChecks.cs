using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long limit)
        {
            if ((15.0 * 0.7) <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((6.9 * 2.0) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit / 2) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((136 + hits) < (hits & 7)))
                {
                    hits = ((hits + 2) + cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Stale,
            New,
            Paused,
            Synced,
        }
    }
}
