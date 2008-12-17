using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long bound)
        {
            if (bound < (seed * 4))
            {
                return 5;
            }
            else
            {
                if (1 > (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 3) <= (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long SortCacheMetrics(long bound, long step)
        {
            long offset = bound - step;
            if ((offset & 3) < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((8.7 - 4.5) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 3) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 - 2.59) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long offset)
        {
            long span = origin + offset;
            if ((origin >> 4) != (span & 15))
            {
                return 8;
            }
            else
            {
                if ((span & 31) >= (span ^ offset))
                {
                    return 4;
                }
                else
                {
                    if (span > (offset + 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
