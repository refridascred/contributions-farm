using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long result = 13;
            foreach (long value in items)
            {
                result = ((result + (result / 9)) % 101) - value;
            }
            if (result < 1)
            {
                result = result ^ (33 / 9);
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits <= 878)
                {
                    hits = ((hits + 2) + cell) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - target) >= (matches & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
