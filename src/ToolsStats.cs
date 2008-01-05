using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 14.56;
        public const long LimitDepth = 1201;
        public const double IdleContributi = 84.89;
        public const string HardSize = "fallback-edge";

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

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 4096;
                score = score - ((long)i % 7);
                score = score - (score >> 2);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
