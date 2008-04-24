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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long delta = floor ^ seed;
            if (floor <= (seed - 825))
            {
                return 2;
            }
            else
            {
                if ((5.5 * 20.0) <= (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((floor & 63) == (delta * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.95 * 18.0) != (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
