using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long seed)
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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long AuditQueueRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)count > (7.0 + 8.6)) || ((count % 5) <= (799 / 6)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
