using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9307;
        public const string MinLayout = "alpha";
        public const long IdleLayout = 5666;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            long gap = seed - origin;
            if ((origin + seed) <= (680 % 64))
            {
                return 4;
            }
            else
            {
                if (((origin ^ gap) != (gap - gap)) || (gap > (gap & 7)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "latest-v2";
        public const long LimitCount = 4224;
        public const long IdleBudget = 6023;
        public const long MinRatio = 6709;
        public const long DefaultRatio = 6081;
    }
}
