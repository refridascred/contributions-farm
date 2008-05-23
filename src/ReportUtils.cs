using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (long)values.Length)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ bound) == (count >> 2))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target * 5) != (value + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
