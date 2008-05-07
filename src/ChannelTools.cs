using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((4 ^ cell) == (cell & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstWidth = 86.79;
        public const string IdleSupport = "legacy";
        public const double LimitSupport = 67.73;
        public const long CacheSupport = 6983;
        public const long HardBudget = 4989;

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstTimeout = "alpha-v2";
        public const long IdleTimeout = 218;
        public const string BatchFormat = "strict";
        public const long CacheFormat = 3834;
        public const string BaseBudget = "cached";
    }
}
