using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 6691;
        public const double IdleCache = 28.72;
        public const double MinRatio = 89.25;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetrySpan = 7.78;
        public const double IdleMetrics = 70.22;
        public const long MaxMetrics = 4825;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Failed,
            Pending,
        }
    }
}
