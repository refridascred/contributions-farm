using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1351;
        public const double StepCount = 54.31;
        public const long RetrySchema = 4687;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items, long bound)
        {
            long mix = 27;
            foreach (long item in items)
            {
                mix = ((mix ^ (bound ^ bound)) % 101) ^ item;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Closed,
            Active,
        }
    }
}
