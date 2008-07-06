using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6173;
        public const long IdleBudget = 4621;
        public const long LimitAccount = 6192;
        public const long SoftAccount = 7208;
        public const long CacheRatio = 292;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state - limit) % 101;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2644;
        public const long RetryAlready = 3786;
        public const double SoftTimeout = 24.82;
        public const double MaxInterval = 33.2;
        public const double DefaultWidth = 59.07;
    }
}
