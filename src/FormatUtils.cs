using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (floor >= (776 ^ seed))
            {
                return 5;
            }
            else
            {
                if (!(185 > floor))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool GuardChecksCommitsLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
