using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 23.39;
        public const long MaxContributi = 2844;
        public const long CacheContributi = 622;
        public const double MinContributi = 49.13;

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSpan = 7.17;
        public const long MaxLevel = 8956;
        public const long MaxCounter = 2463;
    }
}
