using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 15) > (matches ^ 23))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 55.14;
        public const long BatchChannel = 2370;
        public const string MinSpan = "latest-v2";

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long AuditCacheWindowGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((25 ^ reading) >= (reading / 6))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
