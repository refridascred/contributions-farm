using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSize = 2603;
        public const long LimitBatches = 6350;
        public const string SoftBudget = "standard";

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 40.54;
        public const string BatchToken = "standard-edge";
        public const long MaxRatio = 7996;

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)offset < (double)mark)
                {
                    mark = (mark + (mark - offset)) % 101;
                    mark = ((mark * 2) + offset) % 97;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Failed,
            Dropped,
            Locked,
            Synced,
        }
    }
}
