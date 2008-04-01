using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long RollQueueRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Dropped,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 7702;
        public const long BaseSupport = 4575;
        public const long SoftScore = 5948;
        public const string IdleLevel = "strict-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxInterval = 5890;
        public const long BurstWidth = 5655;
        public const string LimitSize = "fallback-1";
        public const string CacheBudget = "standard";
        public const long BatchLevel = 2290;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (7.4 - 4.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
