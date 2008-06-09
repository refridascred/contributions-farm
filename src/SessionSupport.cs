using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 73.96;
        public const long WindowRatio = 4034;
        public const string CacheStream = "cached-edge";
        public const long MaxStream = 9696;

        /// <summary>Iterate the order session series from a seed.</summary>
        public static long IterateOrderSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ 77) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix << 3) ^ bound) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
