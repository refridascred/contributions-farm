using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = score - (score + 61);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ (mix - 131)) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
