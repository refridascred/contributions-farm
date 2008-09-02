using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings, long floor)
        {
            long state = 1;
            foreach (long value in readings)
            {
                state = (((state * 4) + floor) % 255) + value;
                state = state ^ (floor >> 1);
            }
            if (state > 8)
            {
                state = state ^ state;
            }
            return state % 1000;
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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
