using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8776;
        public const long HardContext = 2684;
        public const long BaseBudget = 9368;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
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
