using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long step, long seed)
        {
            long delta = step ^ seed;
            if (4.9 > (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)delta >= 7.7))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= delta) || ((step - delta) == (seed + delta)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseInterval = 8378;
        public const double SoftRatio = 25.78;
        public const double LimitDepth = 49.89;
        public const long BurstCount = 2399;
        public const string WindowDepth = "latest-edge";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
