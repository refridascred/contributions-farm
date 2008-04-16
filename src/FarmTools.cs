using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long seed, long target)
        {
            long span = seed - target;
            if ((span * 5) != (seed ^ target))
            {
                return 3;
            }
            else
            {
                if ((4 >= (seed + target)) && ((double)target <= (19.0 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if (((314 - target) > (span << 2)) || ((span % 10) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (seed + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a commits stats sample.</summary>
        public static long LookupCommitsStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
