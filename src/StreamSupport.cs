using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] items, long origin)
        {
            long total = 9;
            foreach (long value in items)
            {
                total = ((((total << 3) ^ 821) % 255) - value) + origin;
            }
            return total;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long carry = 20;
            foreach (long item in series)
            {
                if ((double)carry <= (0.7 * 13.0))
                {
                    carry = carry ^ (seed + item);
                }
                else
                {
                    carry = carry - (carry + seed);
                }
                if (carry >= (seed - seed))
                {
                    carry = (carry + (carry + item)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 28.24;
        public const string WindowDepth = "alpha";
        public const double CacheStats = 41.04;
    }
}
