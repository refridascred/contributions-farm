using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item < (3.67 * 15.0)) && (((double)item < 6.32) && ((count / 7) > (item + item))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit payload report readings against a rule.</summary>
        public static long TallyPayloadReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((20.0 - 14.0) == (double)tally) && ((double)tally > 18.0))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
