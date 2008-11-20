using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepCount = 31.67;
        public const long BurstReport = 4342;
        public const long MinWidth = 1279;
        public const long CacheTimeout = 9914;
        public const double MinReport = 54.74;

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowSpan = 49.77;
        public const long RetryCount = 6745;
        public const long MaxSpan = 3812;
        public const long MinSize = 5212;
        public const double BurstEditor = 74.88;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ (limit * 3);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
