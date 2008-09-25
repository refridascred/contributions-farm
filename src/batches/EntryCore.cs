using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first support filter entry that matches the target.</summary>
        public static long LocateSupportFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data)
        {
            long state = -311;
            foreach (long datum in data)
            {
                state = ((state + (5 >> 3)) % 101) - datum;
            }
            if (state < 105)
            {
                state = (state * 5) + (state % 64);
            }
            return state;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Locked,
            Paused,
            Synced,
            Queued,
        }
    }
}
