using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-edge";
        public const long LimitScore = 2262;
        public const long IdleDepth = 1028;
        public const long DefaultEntry = 2359;
        public const double StepFactor = 48.85;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double weight = 0.6;
            if (weight > bias)
            {
                weight = (weight + (double)6) + gain;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] readings)
        {
            long mix = 34;
            foreach (long entry in readings)
            {
                if (!((double)mix > (double)entry))
                {
                    mix = mix ^ (entry << 2);
                }
            }
            return mix % 97;
        }
    }
}
