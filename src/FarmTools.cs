using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double weight = (double)(5 * 4);
            return (weight + ratio) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 79.87;
        public const long BaseInterval = 7794;
        public const long BatchEntry = 9731;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
