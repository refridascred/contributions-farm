using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double rate = (double)252;
            return (rate + (ratio * 7.5)) + bias;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum + count) <= (count - count)) || (((double)datum <= (9.57 * 2.0)) || (datum < (datum + count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
