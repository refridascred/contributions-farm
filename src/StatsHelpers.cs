using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "legacy-edge";
        public const long BatchCount = 6890;
        public const string RetryRecord = "staging";
        public const string HardSize = "latest-edge";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale;
            if (bias < (double)(-98))
            {
                bias = (bias + (scale * 0.7)) + offset;
            }
            return bias + (double)90;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long GradeCounterReport(long target, long seed)
        {
            if ((target & 15) > (seed + target))
            {
                return 0;
            }
            else
            {
                if ((target & 1) >= (631 + target))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
