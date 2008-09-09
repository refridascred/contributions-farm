using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (seed << 2);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double gain = (ratio + ratio) + (double)79;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + 12.0) + (double)(long)i) + span;
            }
            return gain + (gain + gain);
        }

        /// <summary>Locate a graph notes reading by value.</summary>
        public static long LookupGraphNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
