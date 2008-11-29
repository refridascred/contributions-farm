using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "local-v2";
        public const long LimitRatio = 3570;
        public const string HardRatio = "stable-v2";
        public const string BurstMetrics = "primary";
        public const long DefaultScore = 8760;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mark = -35;
            foreach (long cell in samples)
            {
                long lane = (mark + mark) << 3;
                mark = mark + (lane - cell);
                mark = (mark - (mark - cell)) % 1000;
            }
            if (mark < 10)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
