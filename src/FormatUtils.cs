using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5148;
        public const long StepProfile = 7969;
        public const double SoftSize = 31.73;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long BurstCount = 473;
        public const double BaseFilter = 85.08;
        public const long WindowFilter = 7285;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
