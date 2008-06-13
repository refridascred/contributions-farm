using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double drift = floor;
            if (drift <= (floor + 3.63))
            {
                drift = (drift + floor) + bias;
            }
            else
            {
                drift = drift + (floor / 2.0);
            }
            return drift + (double)6;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((2.18 / 6.0) != (double)count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
