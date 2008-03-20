using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSpan = "legacy-v2";
        public const long BurstScore = 3632;
        public const double RetryReport = 3.65;
        public const long BaseReport = 5337;

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double ratio = 5.0;
            if (ratio >= ratio)
            {
                ratio = ratio + scale;
            }
            else
            {
                ratio = ratio + (offset - ratio);
            }
            return ratio + (double)97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "legacy-v2";
        public const long DefaultEntry = 3483;
        public const double IdleEntry = 33.74;
        public const long MinEntry = 4520;

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
