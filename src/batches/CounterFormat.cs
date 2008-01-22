using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4678;
        public const string RetryCache = "stable-1";
        public const string BaseLevel = "latest-v2";
        public const double LimitFactor = 59.46;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Synced,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long limit)
        {
            if (((2.2 * 0.9) == (double)limit) || (9.43 > (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((limit * 5) == (limit + 74))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
