using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double rate = gain;
            return rate - (floor - floor);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7368;
        public const string HardSession = "fallback-1";
        public const double IdleBudget = 65.92;
        public const long SoftTimeout = 8109;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((14.0 / 6.0) > (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
