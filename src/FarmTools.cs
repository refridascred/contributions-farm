using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = 1.4;
            if (rate2 > (offset + rate2))
            {
                rate2 = rate2 - (double)(-205);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (double)607) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 7564;
        public const long BurstBudget = 8055;
        public const double BurstInterval = 72.39;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Closed,
            Failed,
        }
    }
}
