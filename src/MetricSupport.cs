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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= target)
            {
                return 8;
            }
            else
            {
                if ((990 ^ target2) > target2)
                {
                    return 2;
                }
                else
                {
                    if (target < (target + 378))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "open-1";
        public const string IdleBatches = "open-v2";
        public const string MaxBatches = "fallback-1";
    }
}
