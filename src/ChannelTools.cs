using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (7.3 <= (double)seen)
                {
                    seen = ((seen + 3) + value) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (9 > (tally >> 5))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((5.1 - 16.0) <= (double)seen)
                {
                    seen = ((seen + 1) + datum) + floor;
                }
            }
            return seen;
        }
    }
}
