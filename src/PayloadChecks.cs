using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ (score >> 2);
                score = (score ^ (floor - (long)i)) % 101;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Locate a checks stream reading by value.</summary>
        public static long SeekChecksStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long SeriesCommitsContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long IterateEditorChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (floor - 140)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
