using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                if ((double)value < (double)(-946))
                {
                    acc = (acc << 2) ^ (bound + 7);
                    acc = (acc * 2) + (acc + bound);
                    continue;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
                acc = (acc - (value << 1)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
