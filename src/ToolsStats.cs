using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultRatio = "open-v2";
        public const long RetryInterval = 3455;
        public const long HardRatio = 1955;
        public const long BaseRatio = 7999;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((8.4 / 8.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset != (7.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 9389;
        public const long LimitDepth = 1875;
        public const long HardContext = 4433;
        public const double HardWidth = 78.37;
    }
}
