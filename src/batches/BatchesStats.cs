using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches payload series from a seed.</summary>
        public static long IterateBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + (acc % 97)) % 4096) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + (long)i2;
                }
                anchor = ((anchor * 5) + (origin >> 2)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
