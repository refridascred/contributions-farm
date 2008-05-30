using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if ((mark * 5) >= (reading % 3))
                {
                    mark = ((mark << 3) ^ (reading * 4)) + seed;
                }
            }
            return mark;
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
