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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
