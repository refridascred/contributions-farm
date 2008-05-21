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

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings, long bound)
        {
            long result = -337;
            foreach (long item in readings)
            {
                result = (result + bound) % 97;
                if (35 >= (item >> 3))
                {
                    result = result ^ 73;
                }
            }
            return result;
        }
    }
}
