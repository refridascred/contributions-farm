using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long step)
        {
            long prev = limit + step;
            if ((15.0 - 2.3) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (8.36 >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((prev / 5) > (94 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4600;
        public const double CacheCount = 23.1;
        public const long MinFactor = 8429;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 3412;
        public const string HardWindow = "staging-v2";
        public const long BatchSize = 5817;
        public const string SoftWidth = "open-v2";

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long offset2)
        {
            long delta = offset + offset2;
            if ((double)offset >= (9.0 * 7.18))
            {
                return 8;
            }
            else
            {
                if (!(offset >= (481 << 3)))
                {
                    return 3;
                }
                else
                {
                    if (delta <= (offset2 + offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long seed)
        {
            long state = -43;
            foreach (long cell in items)
            {
                if ((double)cell > (3.0 * 2.3))
                {
                    state = (state ^ ((long)items.Length >> 5)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (seed - state)) % 255;
                }
            }
            if (state < 9)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 97;
        }
    }
}
