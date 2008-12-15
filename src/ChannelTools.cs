using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 90.99;
        public const string MaxRatio = "fallback-v2";
        public const string SoftInterval = "primary";
        public const long DefaultSize = 3405;
        public const long MaxQueue = 9610;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double scale = span;
            if (scale <= (double)67)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 0.6;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches >> 2) == (bound + datum)) && ((double)matches >= (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
