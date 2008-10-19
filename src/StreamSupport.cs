using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double gain = rate / 4.0;
            if (gain > (span + gain))
            {
                gain = gain - 7.56;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (span + rate)) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6045;
        public const double DefaultWidth = 49.26;
        public const string MaxWidth = "legacy-v2";
        public const long SoftSize = 4234;
        public const double BatchSession = 8.23;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5217;
        public const double IdleDepth = 38.77;
        public const long BurstContributi = 6547;
    }
}
