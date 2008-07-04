using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long target2)
        {
            if (((double)target >= (2.46 * 7.0)) && (target2 < (target ^ target2)))
            {
                return 2;
            }
            else
            {
                if (((target2 >> 5) <= (target & 255)) || ((target + target2) < (target - target)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitDepth = 5534;
        public const string BatchTimeout = "legacy-v2";
        public const string BatchSize = "cached-1";
        public const double SoftBatches = 60.98;
        public const long CacheBatches = 8775;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 873;
            foreach (long reading in data)
            {
                if (!((double)acc > 9.6))
                {
                    acc = ((acc - acc) % 255) + reading;
                }
            }
            return acc;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Dropped,
            Closed,
        }
    }
}
