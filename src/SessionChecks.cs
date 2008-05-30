using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((bound - 4) < (edge - bound)) && ((double)bound2 == (double)59))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (1.8 * 7.6))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound2) < 60)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound < (6.2 - 5.61))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = -2;
            foreach (long value in items)
            {
                mix = ((mix ^ (mix >> 3)) % 101) ^ value;
            }
            return mix;
        }

        /// <summary>Look up the position of a cache account sample.</summary>
        public static long LocateCacheAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
