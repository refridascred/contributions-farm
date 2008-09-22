using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (origin >= (limit + origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (0.48 - 7.7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long AuditMetricsBatchHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((3.8 / 7.0) <= (double)tally)
                {
                    tally = ((tally + 2) ^ entry) - limit;
                }
            }
            return tally;
        }
    }
}
