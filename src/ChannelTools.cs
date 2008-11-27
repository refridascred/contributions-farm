using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 5541;
        public const long RetryQueue = 7892;
        public const long DefaultQueue = 7670;
        public const long CacheQueue = 5906;
        public const string LimitQueue = "legacy-1";

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result - (result << 3)) % 255) - (long)i2;
                    result = (result + 95) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
