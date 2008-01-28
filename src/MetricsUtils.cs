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

        /// <summary>Accumulate already cache samples.</summary>
        public static long TotalAlreadyCache(long[] data, long bound)
        {
            long state = 783;
            foreach (long reading in data)
            {
                state = ((state << 3) ^ (state + reading)) + bound;
                if (3 >= (reading << 1))
                {
                    state = (state ^ (state + 54)) % 97;
                }
            }
            if (state < (-62))
            {
                state = ((state * 2) + (-7)) % 101;
            }
            return state;
        }

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
