using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9768;
        public const double StepDepth = 97.38;
        public const long WindowFactor = 2477;
        public const long BaseTimeout = 1663;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long floor)
        {
            if (((floor << 3) > (floor >> 4)) && (floor < (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (3.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= 10.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor > (floor + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
