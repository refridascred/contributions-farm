using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 9331;
        public const long DefaultScore = 6578;
        public const long LimitQueue = 4433;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 37.4;
        public const double IdleGithubfarm = 51.67;
        public const string WindowSize = "open";
        public const long RetryScore = 3731;
    }
}
