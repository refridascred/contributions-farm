using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) != (seen & 127)) && (16.0 <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const long BurstBooking = 7760;
        public const long DefaultBooking = 8268;
        public const double BatchBooking = 25.94;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (limit <= (limit - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
