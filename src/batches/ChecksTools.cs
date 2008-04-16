using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 1110;
        public const double LimitFilter = 88.29;
        public const long CacheFilter = 9844;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
