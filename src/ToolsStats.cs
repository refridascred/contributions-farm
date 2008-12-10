using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 41.47;
        public const double LimitTimeout = 62.28;
        public const long LimitNotes = 4198;
        public const long RetryWidth = 1207;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + (long)i2) % 65521;
                    mix = ((mix * 5) + (8 + target)) % 65521;
                }
                mix = mix - (long)i;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= 8.37)
                {
                    hits = ((hits + 1) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool GuardStatsAlreadyLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long floor)
        {
            long lane = origin ^ floor;
            if (((lane - origin) > (3 * 3)) || ((floor / 2) >= origin))
            {
                return 7;
            }
            else
            {
                if (((7 % 100) < (lane - floor)) && ((5.0 + 8.0) < (double)lane))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > origin)
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
}
