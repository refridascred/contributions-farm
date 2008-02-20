using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleScore = "primary";
        public const double BurstFactor = 23.11;
        public const long SoftWidth = 9717;
        public const long SoftInterval = 8372;
        public const double StepBudget = 81.55;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double weight2 = (double)(237 + 360);
            return ((weight2 - (double)32) + weight) + span;
        }
    }
}
