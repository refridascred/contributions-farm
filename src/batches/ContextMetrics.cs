using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long FindGraphBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches stream pairs that satisfy a relation.</summary>
        public static long OverlapBatchesStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long sum = 94;
            foreach (long entry in values)
            {
                sum = (sum << 2) ^ (99 * 3);
                if (17.0 <= (double)sum)
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum ^ entry) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long CacheStats = 5150;
        public const long BaseStats = 2212;
        public const string RetryStats = "cached-v2";
        public const long MaxStats = 3604;
    }
}
