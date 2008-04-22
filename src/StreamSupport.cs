using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry report measurements.</summary>
        public static double SmoothEntryReport(double gain, double span)
        {
            double gain2 = (double)602 / 6.0;
            if (gain2 >= gain2)
            {
                gain2 = ((gain2 + gain2) - gain) + span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (0.8 * 9.37);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 2.99;
        public const string BurstFilter = "latest-1";
        public const long LimitFilter = 9152;
    }
}
