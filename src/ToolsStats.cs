using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftTimeout = 6355;
        public const string CacheProfile = "alpha-v2";
        public const long LimitProfile = 6239;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy";
        public const string SoftEntry = "standard-edge";
        public const string LimitEntry = "latest-1";
        public const long MaxEntry = 4325;
        public const long BatchEntry = 6000;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4361;
        public const double BatchDepth = 95.05;
        public const double MaxReport = 90.69;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + target) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
