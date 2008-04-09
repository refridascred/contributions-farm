using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (407 & 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double load = (double)26 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + (load - load)) + (double)(long)i) + ratio) - floor;
            }
            return load - (double)14;
        }
    }
}
