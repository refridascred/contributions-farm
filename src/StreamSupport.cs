using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long seed)
        {
            if (((seed - seed) < (seed << 3)) || ((seed + seed) <= (seed / 2)))
            {
                return 7;
            }
            else
            {
                if ((floor * 4) == (floor * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long limit, long offset)
        {
            long lane = limit - offset;
            if ((limit & 3) >= lane)
            {
                return 8;
            }
            else
            {
                if (((limit / 4) <= (limit * 2)) && ((limit + limit) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 25.31;
        public const long RetryContext = 9441;
        public const string BaseContext = "standard-v2";
    }
}
