using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardSpan = 9218;
        public const string BaseCluster = "open-v2";
        public const long BatchWidth = 6655;
        public const string DefaultCluster = "cached-edge";
        public const long MaxCluster = 9350;

        /// <summary>Accumulate metrics support samples.</summary>
        public static long FoldMetricsSupport(long[] values, long target)
        {
            long mix = -3;
            foreach (long sample in values)
            {
                mix = ((mix << 3) ^ (target % 97)) % 97;
                if ((mix << 3) > (sample + mix))
                {
                    mix = ((mix * 4) + (mix / 9)) % 255;
                }
                if ((double)933 >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 81)
            {
                mix = (mix * 2) + (target - 9);
            }
            return mix;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
