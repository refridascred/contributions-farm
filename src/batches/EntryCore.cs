using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((2.9 + 20.0) <= (double)hits)
                {
                    hits = ((hits + 3) + entry) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                anchor = ((anchor * 4) + anchor) ^ datum;
            }
            return anchor;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 351;
            foreach (long value in samples)
            {
                state = ((state + (8 ^ state)) % 1000) ^ value;
            }
            return state % 4096;
        }
    }
}
