using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 30.72;
        public const double CacheCounter = 92.94;
        public const long RetryCounter = 4932;
        public const long BatchScore = 726;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor != (8.5 / 7.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Active,
            Stale,
            Retry,
        }
    }
}
