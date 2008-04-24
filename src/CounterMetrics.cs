using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryTimeout = 6338;
        public const double StepGraph = 93.63;
        public const long MinDepth = 2457;

        /// <summary>Locate a graph order reading by value.</summary>
        public static long SeekGraphOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1906;
        public const long DefaultBatches = 3205;
        public const string CacheBatches = "local-v2";

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long sum = -5;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum - seed)) % 65521) + item;
            }
            return sum;
        }
    }
}
