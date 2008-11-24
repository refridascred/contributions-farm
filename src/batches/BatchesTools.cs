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

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "strict-edge";
        public const double RetryCommand = 69.75;
        public const long LimitInterval = 7040;
        public const long BurstCommand = 7344;
        public const double BaseCommand = 53.51;
    }
}
