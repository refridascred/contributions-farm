using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheFactor = 6545;
        public const long HardQueue = 8992;
        public const long BaseDepth = 9034;
        public const double RetryFactor = 48.34;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "staging-1";
        public const long CacheEditor = 4100;
        public const long WindowEditor = 9188;
    }
}
