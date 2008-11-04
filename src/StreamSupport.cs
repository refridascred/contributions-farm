using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 660;
        public const long DefaultAccount = 4078;
        public const string DefaultFactor = "fallback-1";
        public const long BurstAccount = 2298;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (total ^ (total - datum)) % 101;
            }
            if (total < 92)
            {
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            long offset = limit + target;
            if ((target % 16) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
