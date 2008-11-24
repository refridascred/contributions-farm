using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long CountProfileStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - cell) == (cell % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
