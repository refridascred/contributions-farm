using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already report input into a small class.</summary>
        public static long RankAlreadyReport(long origin, long target)
        {
            if ((target & 7) > (origin + origin))
            {
                return 2;
            }
            else
            {
                if (((8.3 - 3.8) > (double)origin) || (target <= (target / 8)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate contributi checks samples.</summary>
        public static long WeighContributiChecks(long[] data, long origin)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (((sum % 2) < cell) && ((cell ^ sum) >= (50 >> 3)))
                {
                    sum = ((sum - (sum * 5)) % 97) - origin;
                    continue;
                }
                sum = sum - (sum - sum);
            }
            if (sum > 8)
            {
                sum = (sum - (661 ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
