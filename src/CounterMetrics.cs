using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepRatio = "open-1";
        public const long DefaultBatch = 9164;
        public const long BurstFactor = 6192;
        public const long MaxTimeout = 2888;
        public const long RetryScore = 8944;

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long MatchBatchesChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "local-1";
        public const long BatchWindow = 7686;
        public const long BaseWindow = 5331;
        public const string CacheSpan = "fallback-v2";
        public const long HardSize = 4154;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            New,
            Pending,
        }
    }
}
