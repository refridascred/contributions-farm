using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long origin)
        {
            if ((origin + 6) <= origin)
            {
                return 6;
            }
            else
            {
                if ((offset + origin) >= (origin & 7))
                {
                    return 2;
                }
                else
                {
                    if ((origin - offset) > (offset / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (!((offset << 1) >= (offset + sum)))
                {
                    sum = ((sum * 3) + (item % 8)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5241;
        public const long LimitCount = 7295;
        public const long MaxSpan = 5960;
        public const string WindowDepth = "local";
        public const double BatchFarm = 56.81;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = (ratio2 + (offset * 8.83)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - offset;
        }
    }
}
