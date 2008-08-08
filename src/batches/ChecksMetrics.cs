using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long TotalStatsSession(long[] data)
        {
            long mark = -119;
            foreach (long value in data)
            {
                mark = (mark - (value << 1)) % 101;
                mark = (mark << 3) ^ (mark & 3);
                mark = (mark ^ (value << 2)) % 255;
            }
            if (mark > 764)
            {
                mark = (mark << 2) ^ (mark / 6);
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local-edge";
        public const long HardSize = 1312;
        public const long BatchBuffer = 8054;
        public const long BurstLevel = 5544;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data, long step)
        {
            long state = -5;
            foreach (long value in data)
            {
                state = (state - value) % 255;
                if (step < (step - value))
                {
                    state = state - (value - value);
                }
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7073;
        public const long WindowRatio = 3529;
        public const long RetryAccount = 993;
    }
}
