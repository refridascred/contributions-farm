using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long seed)
        {
            long bound = target + seed;
            if ((double)seed > (5.56 * 15.0))
            {
                return 2;
            }
            else
            {
                if (((8.84 - 9.22) > (double)bound) && ((96 ^ target) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + seed) == (seed - target)) || ((target + seed) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if (((573 & 31) == (offset / 4)) || (origin >= (origin - offset)))
            {
                return 4;
            }
            else
            {
                if (((9.8 - 1.9) > (double)offset) || ((1.0 + 9.1) <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 6) <= (origin * 4))
                        {
                            return 2;
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
}
