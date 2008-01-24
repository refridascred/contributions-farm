using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Pending,
            Stale,
            Locked,
            New,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long limit)
        {
            long state = 157;
            foreach (long item in data)
            {
                state = ((state << 3) ^ limit) ^ item;
            }
            if (state < 3)
            {
                state = state - (state - limit);
            }
            return state;
        }
    }
}
