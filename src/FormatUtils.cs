using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long MeasureAlreadyStreamMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample == (double)(long)readings.Length) || ((bound & 127) <= (3 & 255)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchFactor = 62.78;
        public const long CacheMetrics = 9580;
        public const long LimitDepth = 3133;
        public const long SoftMetrics = 7105;
        public const string IdleMetrics = "fallback";

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
