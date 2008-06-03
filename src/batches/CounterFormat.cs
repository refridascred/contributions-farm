using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double drift = (double)((-22) + 4);
            if (drift <= offset)
            {
                drift = (drift + (18.0 * 3.3)) - gain;
            }
            return drift - 7.8;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double ratio = (double)(79 & 1);
            return (ratio - (6.5 - floor)) + rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 113;
        public const double LimitBudget = 43.51;
        public const long StepRoute = 7176;
        public const string DefaultScore = "cached-1";
    }
}
