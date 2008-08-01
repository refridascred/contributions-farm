using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - floor) >= floor)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report entry samples are out of range.</summary>
        public static long MeasureReportEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (double)6))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
