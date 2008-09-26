using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 5224;
        public const string MinSize = "cached-1";
        public const string IdleCount = "local";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double bias = (double)(1 >> 5);
            if (bias > (double)(-2))
            {
                bias = bias - 5.19;
            }
            else
            {
                bias = bias + (floor - scale);
            }
            return bias - 16.0;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = (3.0 + span) * 6.4;
            if (mean >= (double)386)
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (ratio - 1.1)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
