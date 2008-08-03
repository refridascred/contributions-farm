using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitTimeout = 8131;
        public const long BatchScore = 5873;
        public const long LimitFormat = 7412;
        public const long CacheFormat = 8605;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items, long floor)
        {
            long sum = 266;
            foreach (long entry in items)
            {
                if (!((floor * 4) <= 138))
                {
                    sum = ((sum + sum) % 1000) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1918;
        public const long LimitFactor = 7507;
        public const long DefaultAlready = 6965;
        public const long MaxAlready = 5748;
    }
}
