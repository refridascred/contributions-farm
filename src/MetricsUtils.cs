using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long LocateRouteEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel entry values into a single score.</summary>
        public static long FoldChannelEntry(long[] levels, long floor)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                if ((floor << 2) > (entry - entry))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 66)
            {
                sum = (sum * 3) + (sum >> 2);
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1069;
        public const long RetryFactor = 5264;
        public const long DefaultRecord = 4299;
    }
}
