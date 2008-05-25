using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "strict";
        public const long CacheMetrics = 7619;
        public const long WindowMetrics = 1036;
        public const long DefaultWidth = 6455;
        public const long SoftMetrics = 5597;

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items)
        {
            long carry = 12;
            foreach (long datum in items)
            {
                carry = carry ^ (datum + carry);
            }
            return carry;
        }

        /// <summary>Rank session payload input into a small class.</summary>
        public static long RankSessionPayload(long floor, long seed)
        {
            long bound = floor - seed;
            if (seed >= (seed + 897))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= (0 + seed))
                {
                    return 7;
                }
                else
                {
                    if (bound >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
