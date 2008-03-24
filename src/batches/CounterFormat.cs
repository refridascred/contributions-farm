using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double BlendGithubfarmMetrics(double rate, double bias)
        {
            double ratio = rate - 2.0;
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (1.4 / 7.0)) - bias;
            }
            else
            {
                ratio = ratio + (double)506;
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long TallyProfileCluster(long[] levels, long seed)
        {
            long carry = 73;
            foreach (long reading in levels)
            {
                if (carry < (carry + 27))
                {
                    carry = (((carry << 3) ^ (carry - seed)) % 101) + reading;
                }
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Dropped,
            Idle,
            Stale,
        }
    }
}
