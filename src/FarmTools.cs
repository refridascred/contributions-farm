using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                anchor = (anchor + item) % 255;
            }
            if (anchor > 247)
            {
                anchor = ((anchor << 3) ^ (anchor / 5)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double load = (9.5 * 5.59) + (4.59 / 8.0);
            return load - (scale - span);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
