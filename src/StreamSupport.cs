using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8080;
        public const double MaxRatio = 14.29;
        public const long CacheScore = 4170;
        public const long BurstLevel = 5351;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftFactor = 85.93;
        public const long RetrySchema = 8967;
        public const long BatchSchema = 6375;
        public const double SoftScore = 57.2;
        public const long SoftWidth = 5992;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
