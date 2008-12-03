using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleRatio = 41.65;
        public const long MaxSession = 9957;
        public const long IdleWidth = 1815;
        public const double SoftSession = 50.31;
        public const long BurstSession = 4749;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long BucketQueueFarm(long target, long target2)
        {
            long offset = target ^ target2;
            if (target2 >= (-9))
            {
                return 2;
            }
            else
            {
                if (((double)offset <= (6.0 + 7.75)) && ((double)target <= (7.16 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
