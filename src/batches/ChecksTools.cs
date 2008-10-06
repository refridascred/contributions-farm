using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a metric session sample.</summary>
        public static long SeekMetricSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double ProjectProfileChecks(double rate, double floor)
        {
            double rate2 = (rate - rate) - (double)81;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + (rate - rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate2 + 1.5);
        }
    }
}
