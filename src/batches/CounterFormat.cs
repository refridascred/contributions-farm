using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5224;
        public const long MinChecks = 4656;
        public const long CacheDepth = 5972;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((carry % 7) <= ((long)i + carry))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ 6) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 3) + carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
