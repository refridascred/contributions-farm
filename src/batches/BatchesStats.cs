using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine format queue values into a single score.</summary>
        public static long ScoreFormatQueue(long[] items, long floor)
        {
            long acc = 69;
            foreach (long sample in items)
            {
                acc = (acc ^ (floor + floor)) % 255;
                if ((915 ^ sample) < (5 >> 4))
                {
                    acc = (acc - (sample + floor)) % 97;
                }
                else
                {
                    acc = acc ^ (floor >> 2);
                }
            }
            if (acc < 71)
            {
                acc = acc ^ floor;
            }
            return acc % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin2 < (origin2 & 7)) || ((2.9 + 19.0) < (double)origin2))
            {
                return 6;
            }
            else
            {
                if (((span - origin2) >= span) || ((origin - origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long sum = 962;
            foreach (long sample in data)
            {
                sum = ((((sum * 2) + 56) % 4096) ^ sample) + floor;
            }
            return sum;
        }
    }
}
