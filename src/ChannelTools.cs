using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((acc + (long)i) < (offset ^ acc)) && ((double)acc == (4.27 + 8.8)))
                {
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((5.27 * 8.0) < (double)floor))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
