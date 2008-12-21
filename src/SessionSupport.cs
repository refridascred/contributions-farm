using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((double)count >= (double)(long)readings.Length) && ((double)entry > (0.3 - 3.68))) && (((-5) % 12) > (count / 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool ValidateBatchesChecksLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
