using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long seed, long seed2)
        {
            if ((seed >> 1) >= (seed2 << 3))
            {
                return 3;
            }
            else
            {
                if (!((seed2 & 1) < (seed * 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 5) + seed;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit - limit) >= (long)i)
                {
                    anchor = ((anchor * 4) + (long)i) % 1000;
                }
                if ((8.55 / 4.0) < (double)anchor)
                {
                    anchor = (anchor + (limit + limit)) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
