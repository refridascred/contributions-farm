using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((389 < count) || ((1.0 * 14.0) == (double)count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double rate = (4.3 * 4.57) - floor;
            if (rate > (double)917)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (ratio * 4.3);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
