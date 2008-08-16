using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheFactor = 66.59;
        public const long BaseMetric = 8550;
        public const long RetryRatio = 7895;
        public const string StepRatio = "latest-edge";
        public const long CacheCount = 4438;

        /// <summary>Iterate the cache order series from a seed.</summary>
        public static long DeriveCacheOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ (5 << 3)) - (long)i2;
                }
                carry = (carry ^ (carry % 16)) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((double)seed == (5.4 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((step < 2) || ((seed / 8) <= (4 ^ step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
