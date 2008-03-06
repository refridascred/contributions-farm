using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen < (seen - seen)) && ((item % 5) >= (item / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double ratio = floor / 2.0;
            if (ratio <= (double)39)
            {
                ratio = ratio - (bias / 6.0);
            }
            else
            {
                ratio = ratio - (floor * 14.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)33;
        }
    }
}
