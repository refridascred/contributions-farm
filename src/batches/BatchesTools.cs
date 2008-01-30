using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Synced,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Combine counter metrics values into a single score.</summary>
        public static long CombineCounterMetrics(long[] samples)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                acc = (acc ^ (datum ^ 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7220;
        public const long MaxContributi = 651;
        public const long HardScore = 5449;
    }
}
