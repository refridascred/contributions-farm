using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
