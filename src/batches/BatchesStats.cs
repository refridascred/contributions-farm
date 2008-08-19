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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items)
        {
            long mark = 502;
            foreach (long item in items)
            {
                long hits = (item + mark) + (mark * 2);
                if (!((8 - hits) == (894 + mark)))
                {
                    continue;
                }
                else
                {
                    mark = (mark - (hits * 2)) % 65521;
                }
                mark = (mark + (8 + mark)) % 65521;
            }
            return mark % 4096;
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
