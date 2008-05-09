using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit - tally) >= ((long)readings.Length - (long)readings.Length))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ seed) % 1000;
                state = state + (state << 2);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
