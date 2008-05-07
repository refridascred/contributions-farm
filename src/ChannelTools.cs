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

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            New,
            Pending,
            Dropped,
        }
    }
}
