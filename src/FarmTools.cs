using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!(bound >= mix))
                {
                    mix = (mix - (mix % 7)) % 101;
                }
                mix = ((mix * 3) + bound) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((-4) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
