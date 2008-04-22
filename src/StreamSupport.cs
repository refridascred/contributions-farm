using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((slot % 10) == (bound * 3)))
            {
                return 8;
            }
            else
            {
                if (slot < 80)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
