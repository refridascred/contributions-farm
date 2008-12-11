using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally ^ tally) != (reading + 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (floor >= (floor - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            if ((limit2 + limit2) >= (limit / 6))
            {
                return 4;
            }
            else
            {
                if (!((limit2 & 127) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 >= (4 % 60)) && ((double)limit2 < (double)56))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
