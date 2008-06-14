using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record context samples are out of range.</summary>
        public static long TallyRecordContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen * 3) > 18)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((7.9 / 5.0) != (double)slot)
            {
                return 8;
            }
            else
            {
                if ((offset <= offset2) && ((offset / 9) <= (slot - offset)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - 23) <= (entry + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
