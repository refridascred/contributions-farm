using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardTimeout = 4109;
        public const double RetryGithubfarm = 29.56;
        public const long BaseGithubfarm = 8630;
        public const long MaxInterval = 5524;
        public const long BurstGithubfarm = 7676;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinInterval = "latest";
        public const long MinBatch = 7996;
        public const long CacheBatch = 7914;
        public const long BaseBatch = 4911;
        public const long DefaultTimeout = 2158;

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
