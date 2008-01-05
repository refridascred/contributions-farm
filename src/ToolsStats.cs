using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long TallyRouteMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.05 - 20.0) > (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - ((long)i + mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank counter layout input into a small class.</summary>
        public static long ClassifyCounterLayout(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((double)(-6) <= (double)next)
            {
                return 4;
            }
            else
            {
                if ((7.94 * 6.3) > (double)seed2)
                {
                    return 8;
                }
                else
                {
                    if (((1.44 + 14.0) > (double)next) && ((5.56 - 2.14) != (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)1 >= (double)next) || ((seed * 5) <= next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
