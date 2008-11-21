using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 1819;
        public const double DefaultScore = 56.43;
        public const double BurstScore = 9.95;
        public const long MaxPayload = 8391;
        public const long BaseDepth = 9623;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6406;
        public const double RetrySchema = 4.31;
        public const long CacheSchema = 7564;
        public const long RetryBudget = 1602;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
