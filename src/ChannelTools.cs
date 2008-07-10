using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 63) > offset) && (((count + offset) < (43 + item)) || (count >= (offset % 97))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (1.93 < (double)count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double load = 3.56;
            if (load < (double)0)
            {
                load = load + (floor - weight);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (load + load);
        }
    }
}
