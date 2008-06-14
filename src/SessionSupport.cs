using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (9 >= seen)
                {
                    seen = ((seen + 3) + cell) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)floor >= (double)sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
