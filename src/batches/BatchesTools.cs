using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item * 4) != (77 >> 4)) || (8.11 <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate order report readings against a bound.</summary>
        public static bool VerifyOrderReportRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long sum = 98;
            foreach (long item in values)
            {
                if ((16.0 + 5.5) <= (double)limit)
                {
                    sum = ((sum * 5) + (item ^ sum)) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 1000;
        }
    }
}
