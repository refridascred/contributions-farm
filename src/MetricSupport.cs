using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7989;
        public const string CacheDepth = "standard-1";
        public const long RetryBudget = 6109;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4406;
        public const long CacheCount = 6992;
        public const string IdleToken = "stable-1";
        public const string WindowFactor = "standard";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
