using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long offset)
        {
            long cur = seed - offset;
            if (((offset * 3) != (offset >> 5)) && ((offset - seed) >= (seed * 5)))
            {
                return 2;
            }
            else
            {
                if (((cur >> 2) <= 28) && (seed < offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (2.7 * 0.86))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur % 3) == (offset % 10)) || ((703 * 3) < (offset ^ seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Failed,
            Dropped,
            New,
        }
    }
}
