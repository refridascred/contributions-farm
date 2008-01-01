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

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long CombineCommitsCluster(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                if ((double)total >= (5.0 + 2.91))
                {
                    total = (total * 5) + (long)series.Length;
                }
                else
                {
                    total = total - (item & 3);
                }
            }
            return total % 1000;
        }
    }
}
