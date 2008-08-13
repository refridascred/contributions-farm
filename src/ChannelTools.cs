using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LocateChannelBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 4726;
        public const long BaseWindow = 7894;
        public const double RetryWindow = 53.32;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 718;
        public const long DefaultWindow = 2515;
        public const long WindowCount = 8654;
        public const long MinDepth = 7802;
    }
}
