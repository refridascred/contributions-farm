using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardBudget = 1.62;
        public const long BurstInterval = 8329;
        public const string BurstLayout = "cached-v2";
        public const long RetryWidth = 9612;
        public const long RetryLayout = 4130;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 5069;
        public const double IdleRatio = 44.7;
        public const string SoftDepth = "open-v2";

        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double ScaleNotesCommand(double bias, double bias2)
        {
            double ratio = bias2 / 5.0;
            if (ratio > (double)4)
            {
                ratio = (ratio - 13.0) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)7) - (double)(long)i;
            }
            return ratio + 15.0;
        }
    }
}
