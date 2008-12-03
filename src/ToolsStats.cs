using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 2898;
        public const long CacheDepth = 3558;
        public const long StepRecord = 1830;
        public const long IdleRecord = 935;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double load = span;
            if (load > load)
            {
                load = load + (load / 5.0);
            }
            else
            {
                load = load - (span - 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + 2.0)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long target2)
        {
            long bound = target - target2;
            if (419 > (811 - bound))
            {
                return 3;
            }
            else
            {
                if ((target < bound) || ((double)target >= (double)target2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
