using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ origin) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry << 2) ^ (70 >> 4)) % 65521) - (long)i2;
                }
                if ((carry + 895) < (9 & 1))
                {
                    carry = (carry ^ (67 * 5)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 426;
        public const long BatchCount = 5664;
        public const string IdleCount = "cached-v2";
        public const long MaxRoute = 3552;
        public const long SoftTimeout = 4773;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
