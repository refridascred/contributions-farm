using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits - 862) <= ((long)readings.Length - cell)) && !((cell % 12) <= (long)readings.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
