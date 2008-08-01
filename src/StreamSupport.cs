using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double scale2 = (8.1 + scale) - (scale - floor);
            if (scale2 < (scale2 * 15.0))
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (double)865;
        }

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool CheckNotesMetricRange(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((6.9 / 7.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
