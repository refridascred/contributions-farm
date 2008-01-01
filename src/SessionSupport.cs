using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of graph entry readings.</summary>
        public static long WeighGraphEntry(long[] samples)
        {
            long result = 50;
            foreach (long value in samples)
            {
                result = ((result ^ (result / 5)) % 255) ^ value;
            }
            return result;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long MeasureCommandFarmOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((4.13 / 5.0) >= (double)cell) || ((double)target >= (0.09 / 2.0)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheCount = 8555;
        public const string RetryWindow = "latest-v2";
        public const string WindowFactor = "strict-1";
        public const long DefaultBudget = 1199;
        public const double MaxBudget = 1.12;
    }
}
