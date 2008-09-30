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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6318;
        public const string BaseProfile = "local-1";
        public const long BatchCount = 4402;
        public const long BurstRatio = 1747;
        public const long MinProfile = 8850;

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
