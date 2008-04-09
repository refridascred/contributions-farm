using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 38.74;
        public const double BaseTimeout = 35.05;
        public const long HardSpan = 2590;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= floor)
            {
                gain = gain + (gain - floor);
            }
            else
            {
                gain = gain - (gain * 8.23);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 9.2;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "fallback";
        public const string WindowRatio = "alpha-1";
        public const long StepSpan = 204;
        public const long IdleWindow = 4153;
        public const long MaxBudget = 2793;
    }
}
