using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile session series from a seed.</summary>
        public static long IterateProfileSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((-24) <= ((long)i - mark))
                {
                    mark = mark - (67 + seed);
                    mark = ((mark * 5) + (5 >> 1)) % 65521;
                }
                else
                {
                    mark = (mark + (long)i) % 97;
                }
                mark = mark - (mark - 8);
                mark = (mark ^ (mark ^ mark)) % 101;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
