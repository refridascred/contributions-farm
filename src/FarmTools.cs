using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double drift = (double)8;
            if (drift >= 4.4)
            {
                drift = (drift - 16.0) - weight;
            }
            return drift - bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 2861;
        public const long BatchFactor = 8600;
        public const string HardInterval = "latest-1";
        public const double RetryLevel = 87.24;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 / 4) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
