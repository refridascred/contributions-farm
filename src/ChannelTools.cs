using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 4756;
        public const long BaseSize = 3051;
        public const long IdleCluster = 9813;
        public const string HardCount = "standard-v2";
        public const double MinTimeout = 35.41;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheLevel = 3873;
        public const long RetryCount = 2977;
        public const string MaxDepth = "fallback-v2";
        public const string MaxWidth = "stable-v2";
        public const long BaseToken = 2956;
    }
}
