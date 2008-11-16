using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a tools window sample.</summary>
        public static long SeekToolsWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (step > (long)levels.Length)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
