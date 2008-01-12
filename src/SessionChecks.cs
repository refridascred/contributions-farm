using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowCount = 2261;
        public const long BaseSize = 6557;
        public const long BatchInterval = 2494;
        public const long CacheSession = 1651;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Retry,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 3) ^ (824 - (-77));
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
