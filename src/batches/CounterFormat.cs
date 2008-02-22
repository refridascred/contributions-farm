using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitBudget = 9474;
        public const long CacheWidth = 9939;
        public const long CacheMetric = 6096;
    }
}
