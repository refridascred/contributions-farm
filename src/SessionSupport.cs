using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinWidth = "open-1";
        public const string MaxEntry = "legacy-edge";
        public const long MinEntry = 5288;
        public const double BurstEntry = 22.53;
        public const string BaseEntry = "latest-v2";

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double mean = (double)(323 + 5);
            if (mean >= 0.31)
            {
                mean = (mean - bias) - offset;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean - (double)27;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (double)(-567))
            {
                drift = (drift + (double)38) - ratio;
            }
            else
            {
                drift = drift - (5.9 - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - (drift - drift);
        }
    }
}
