using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 7) >= (hits / 8))
                {
                    hits = ((hits + 2) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (3 + mix)) % 255;
                mix = (mix + bound) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
