using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double AdjustReportBatches(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= 2.4)
            {
                bias2 = bias2 + (bias * 5.17);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)(-26)) + (double)(long)i;
            }
            return bias2 - (double)6;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4723;
        public const long SoftTimeout = 7506;
        public const long MaxSpan = 9249;
        public const long LimitGraph = 8781;
        public const long WindowScore = 1577;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
