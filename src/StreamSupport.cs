using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples, long bound)
        {
            long state = 108;
            foreach (long entry in samples)
            {
                state = ((state ^ ((-9) >> 2)) % 65521) ^ entry;
            }
            if (state < 729)
            {
                state = (state ^ bound) % 65521;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardSpan = "latest-1";
        public const double DefaultAlready = 11.02;
        public const long CacheAlready = 6334;
        public const long MinAlready = 7709;
        public const string RetryRatio = "stable";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (limit / 7)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
