using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data)
        {
            long state = 38;
            foreach (long entry in data)
            {
                if (!((state << 1) < state))
                {
                    state = ((state + 3) % 1000) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc * 3) >= ((long)i - bound)))
                {
                    acc = ((acc * 5) + (bound + (long)i)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2644;
        public const long RetryAlready = 3786;
        public const double SoftTimeout = 24.82;
        public const double MaxInterval = 33.2;
        public const double DefaultWidth = 59.07;
    }
}
