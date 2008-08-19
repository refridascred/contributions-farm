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

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((8.44 * 5.1) >= (double)entry)
                {
                    sum = (sum + step) % 97;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
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
