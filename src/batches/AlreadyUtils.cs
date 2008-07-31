using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6051;
        public const double BurstBudget = 2.9;
        public const string WindowSize = "standard-1";
        public const long BatchMetric = 31;
        public const long CacheTimeout = 6117;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7728;
        public const long CacheSize = 3325;
        public const string IdleInterval = "open";
        public const string RetryAccount = "strict-v2";
        public const long SoftAccount = 8666;

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "standard";
        public const long RetryBatches = 9430;
        public const double LimitBatches = 9.27;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
