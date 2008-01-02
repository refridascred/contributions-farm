using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long seed)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ (sample & 31)) % 4096) + seed;
            }
            return mark;
        }

        /// <summary>Validate support window readings against a bound.</summary>
        public static bool CheckSupportWindowRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheRatio = 8334;
        public const long RetryBudget = 2604;
        public const long HardBudget = 1680;
        public const long LimitContributi = 9308;
        public const long WindowTimeout = 5974;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (mark ^ origin);
                mark = mark - (43 & 63);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
