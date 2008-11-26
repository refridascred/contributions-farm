using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8.0 / 9.0) == (double)target)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the commits session entries that pass the check.</summary>
        public static long MeasureCommitsSessionMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) == (entry + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit layout already readings against a rule.</summary>
        public static long TallyLayoutAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
