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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((374 + floor) == (entry * 5)) && ((entry & 31) == (2 - floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
