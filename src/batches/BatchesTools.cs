using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3591;
        public const double StepChecks = 41.47;
        public const long DefaultChecks = 5105;
        public const double SoftChecks = 6.51;
        public const long RetryCount = 6505;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
