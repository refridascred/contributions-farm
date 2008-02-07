using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + matches) > (2 - matches))
                {
                    matches = ((matches + 1) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools batch entries that pass the check.</summary>
        public static long TallyToolsBatchOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((step < (tally + step)) || ((2.8 - 1.6) <= (double)step))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values, long offset)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score ^ (score & 63)) - entry;
                score = (score + 708) % 65521;
            }
            if (score > 5)
            {
                score = score ^ offset;
            }
            return score;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Paused,
            Dropped,
            Stale,
            Queued,
        }
    }
}
