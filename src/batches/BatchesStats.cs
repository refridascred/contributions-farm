using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double mean = (double)(4 - 5);
            return ((mean - (mean * 16.0)) + weight) + floor;
        }

        /// <summary>Scale a report window figure with a bias.</summary>
        public static double AdjustReportWindow(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > 5.0)
            {
                bias2 = bias2 + (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 450;
        public const string MaxBudget = "strict";
        public const double RetryWindow = 57.22;
        public const long BatchWindow = 7097;
    }
}
