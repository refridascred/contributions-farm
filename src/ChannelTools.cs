using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 2859;
        public const long BatchSession = 4188;
        public const long RetrySession = 550;

        /// <summary>Locate a layout order reading by value.</summary>
        public static long FindLayoutOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long DeriveAccountToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + (seed - (long)i);
                if ((seed - result) != (seed + result))
                {
                    result = (result + ((long)i % 16)) % 4096;
                    result = ((result << 3) ^ (result >> 5)) % 65521;
                    break;
                }
                else
                {
                    result = (result + ((long)i & 255)) % 1000;
                }
                result = result ^ (seed - seed);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
