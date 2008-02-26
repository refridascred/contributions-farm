using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long target)
        {
            long span = seed - target;
            if ((9 % 2) > (target * 3))
            {
                return 4;
            }
            else
            {
                if ((span + seed) < (span % 100))
                {
                    return 6;
                }
                else
                {
                    if (seed <= 95)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long seed)
        {
            long gap = bound ^ seed;
            if ((9.0 + 9.2) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((gap / 7) <= (seed - bound)) || ((gap * 5) >= (69 + 828)))
                {
                    return 6;
                }
                else
                {
                    if (seed > 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap - bound) != (gap ^ 49))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (3.0 < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long target)
        {
            long slot = bound - target;
            if ((77 & 7) == (bound % 12))
            {
                return 1;
            }
            else
            {
                if (((slot & 3) > slot) && ((4.4 / 6.0) < (double)slot))
                {
                    return 4;
                }
                else
                {
                    if (((target << 2) < (bound * 3)) && ((double)slot <= (3.0 * 1.14)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + slot) >= (slot + target)) && (((-149) * 5) != (slot << 1)))
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
        }
    }
}
