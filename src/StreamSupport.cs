using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((sum > ((long)i + seed)) && ((sum >> 1) != (seed - (long)i)))
                {
                    sum = (sum ^ (long)i) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryInterval = 8770;
        public const long MinSession = 7309;
        public const long BaseSession = 4276;
        public const double BatchSession = 6.82;
        public const long CacheSession = 4040;
    }
}
