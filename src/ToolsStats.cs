using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 4388;
        public const long LimitReport = 7499;
        public const long DefaultReport = 1826;
        public const double MaxRatio = 35.37;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 315;
            foreach (long item in data)
            {
                if ((mix >> 2) > (item * 2))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitWidth = 5484;
        public const long MaxMetrics = 4539;
        public const string DefaultTimeout = "latest-v2";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Ready,
            Dropped,
            Retry,
            Closed,
        }
    }
}
