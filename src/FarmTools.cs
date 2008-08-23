using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                if ((9 - entry) >= (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = (anchor * 2) + (entry - anchor);
            }
            return anchor;
        }

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long AuditMetricsBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((7 + cell) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((long)values.Length << 2) > (tally ^ tally)) && !((entry & 3) >= (entry << 1)))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
