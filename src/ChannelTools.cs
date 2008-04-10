using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardLevel = 51.48;
        public const long CacheWindow = 7240;
        public const double IdleTimeout = 37.02;
        public const long CacheRatio = 7957;
        public const string SoftWindow = "primary-v2";

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long limit)
        {
            long sum = 15;
            foreach (long item in levels)
            {
                if (!((365 >> 5) > (limit - sum)))
                {
                    sum = (sum * 3) + item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long target)
        {
            if ((step / 3) == (3 / 4))
            {
                return 7;
            }
            else
            {
                if (1 > (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
