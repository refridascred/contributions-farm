using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 788;
            foreach (long item in data)
            {
                total = (((total * 2) + (total + total)) + item) + origin;
            }
            return total;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double rate = (floor / 7.0) + floor;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + floor) + (double)(long)i) + gain;
            }
            return rate - (floor / 9.0);
        }
    }
}
