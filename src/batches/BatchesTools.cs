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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long state = 916;
            foreach (long sample in samples)
            {
                state = ((state - (652 * 2)) % 97) - seed;
                if ((state + sample) >= (state * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
