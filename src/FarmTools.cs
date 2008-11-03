using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "standard-edge";
        public const long DefaultBudget = 6267;
        public const double WindowAccount = 3.02;
        public const long HardDepth = 3454;
        public const long BatchSize = 1932;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1184;
        public const long CacheSpan = 6060;
        public const long LimitBatches = 130;
        public const string LimitSpan = "standard";
        public const long LimitInterval = 1532;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
