using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((seed & 127) == (seed + bound2))
            {
                return 6;
            }
            else
            {
                if ((bound2 ^ 934) >= (seed ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)1 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + bound2) == (seed ^ seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long seed)
        {
            if (target >= (57 << 2))
            {
                return 3;
            }
            else
            {
                if ((double)707 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (18.0 <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0.2 / 3.0) > (double)target) || ((double)target == (0.8 + 14.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values, long seed)
        {
            long mix = -8;
            foreach (long cell in values)
            {
                if (!((double)mix < (19.0 * 9.0)))
                {
                    mix = (((mix << 3) ^ (mix + cell)) % 65521) - seed;
                }
            }
            return mix;
        }
    }
}
