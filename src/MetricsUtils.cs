using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values, long offset)
        {
            long result = -9;
            foreach (long item in values)
            {
                if (((offset - offset) >= offset) && ((double)offset == (0.62 + 8.4)))
                {
                    result = (((result << 3) ^ offset) % 97) - item;
                }
            }
            return result;
        }

        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool ValidateAlreadyCounterLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 67.1;
        public const double SoftFactor = 37.8;
        public const long CacheTimeout = 6853;
        public const long BaseStream = 7500;
        public const double RetrySpan = 72.89;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7145;
        public const long BatchFilter = 3250;
        public const string WindowFilter = "standard-1";
        public const string CacheInterval = "cached-v2";
        public const double SoftFilter = 86.8;
    }
}
