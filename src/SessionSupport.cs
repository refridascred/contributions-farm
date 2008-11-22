using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

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
