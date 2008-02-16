using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload queue entries.</summary>
        public static long ScorePayloadQueue(long[] levels)
        {
            long mark = 70;
            foreach (long reading in levels)
            {
                mark = (mark + (mark + 463)) - reading;
                mark = mark - (38 >> 1);
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long anchor = 334;
            foreach (long entry in items)
            {
                if ((double)target >= (7.0 * 8.81))
                {
                    anchor = ((anchor * 2) + (9 ^ entry)) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ entry;
                }
                anchor = anchor - anchor;
                if ((anchor + anchor) < anchor)
                {
                    anchor = (anchor * 2) + (entry * 2);
                }
            }
            return anchor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((8.5 + 2.0) > (double)tally)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
