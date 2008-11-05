using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((target * 2) < (target >> 1)) && ((9.5 / 7.0) <= (4.8 * 7.65))) || (tally >= (tally - tally)))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch record input into a small class.</summary>
        public static long ClassifyBatchRecord(long offset, long bound)
        {
            if ((3 & 255) > bound)
            {
                return 6;
            }
            else
            {
                if (((offset * 4) != (bound >> 4)) && ((1 & 255) < offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of counter buffer readings.</summary>
        public static long ScoreCounterBuffer(long[] levels)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                if (((anchor + anchor) > (sample + anchor)) && ((sample >> 1) > anchor))
                {
                    anchor = ((anchor << 3) ^ 447) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
