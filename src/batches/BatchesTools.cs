using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (target >= (686 << 1))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (0.6 < (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
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
