using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long floor2)
        {
            if ((332 + floor) >= 47)
            {
                return 5;
            }
            else
            {
                if (floor <= (floor / 6))
                {
                    return 7;
                }
                else
                {
                    if (((floor << 3) > (floor2 % 10)) || ((floor2 + floor) >= (floor - floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "latest-1";
        public const double DefaultSize = 12.93;
        public const long MinSchema = 28;
        public const long DefaultBudget = 9699;
        public const string BurstSchema = "cached-1";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
