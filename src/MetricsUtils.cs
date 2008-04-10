using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Idle,
            Failed,
            Done,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4821;
        public const long MinEditor = 9181;
        public const string BaseEditor = "open";
        public const string BatchWidth = "alpha-v2";
        public const double CacheDepth = 41.89;

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 4290;
        public const double WindowSpan = 25.82;
        public const long HardStream = 7044;
        public const long BatchStream = 4151;
        public const long BaseCount = 4674;

        /// <summary>Validate metrics farm readings against a bound.</summary>
        public static bool ValidateMetricsFarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
