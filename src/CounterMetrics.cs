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

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long step = offset + offset2;
            if ((320 >> 4) >= (6 ^ offset))
            {
                return 6;
            }
            else
            {
                if ((8.49 + 11.0) == (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((4.43 / 3.0) > (double)offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset2 >> 1) < step) || ((double)step == (double)16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
