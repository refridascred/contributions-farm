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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if (((score / 8) > ((long)i * 2)) && ((5.0 - 2.0) > (double)(long)i))
                {
                    score = score ^ (60 << 2);
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "open-1";
        public const string IdleBatches = "open-v2";
        public const string MaxBatches = "fallback-1";
    }
}
