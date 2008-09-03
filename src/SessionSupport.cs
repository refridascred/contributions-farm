using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double weight = 17.0;
            if (weight <= (bias * 9.8))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)(-4)) - (double)(long)i;
            }
            return weight - (floor / 6.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 2912;
        public const string BurstFactor = "legacy-edge";
        public const long RetryStats = 8661;
        public const double MaxStats = 81.66;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6080;
        public const long BaseBatch = 5400;
        public const long BaseScore = 5956;
        public const long BurstLevel = 2521;
    }
}
