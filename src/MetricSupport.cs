using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4707;
        public const double IdleInterval = 29.26;
        public const double HardDepth = 4.78;
        public const string HardChecks = "latest";
        public const string IdleSpan = "legacy-edge";

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
