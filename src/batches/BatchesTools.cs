using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank route already input into a small class.</summary>
        public static long BucketRouteAlready(long floor, long floor2)
        {
            if ((floor & 31) >= (3 & 31))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (4.0 / 5.0)) && (633 > (58 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((200 - floor) < 1)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor < (floor2 & 15))
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
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSize = 3538;
        public const long SoftLevel = 9685;
        public const long BatchBudget = 9488;
        public const double LimitCount = 71.69;
    }
}
