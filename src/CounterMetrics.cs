using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long mix = 0;
            foreach (long value in series)
            {
                if (mix < (value + mix))
                {
                    mix = mix - (value - step);
                }
                else
                {
                    mix = mix - (value ^ mix);
                }
            }
            if (mix < (-17))
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7100;
        public const long RetryDepth = 5587;
        public const string CacheLevel = "standard-v2";
        public const long WindowLevel = 6486;
        public const string LimitScore = "strict-1";

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long RankMetricCommits(long floor, long limit)
        {
            long offset = floor - limit;
            if ((offset << 1) < (floor << 3))
            {
                return 1;
            }
            else
            {
                if ((limit / 2) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) == (offset & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long HardProfile = 2898;
        public const string WindowSize = "legacy-v2";
        public const long BatchProfile = 1167;
    }
}
