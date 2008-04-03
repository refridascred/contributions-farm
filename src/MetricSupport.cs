using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 9610;
        public const long BurstLevel = 3623;
        public const string RetryInterval = "legacy-v2";
        public const long CacheGithubfarm = 2047;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((long)i * 4);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
