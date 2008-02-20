using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + 92) <= (tally % 10))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit schema account readings against a rule.</summary>
        public static long CountSchemaAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches + sample) < (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((7.7 * 2.4) <= (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
