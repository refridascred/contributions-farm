using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream record readings against a rule.</summary>
        public static long AuditStreamRecordOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)count >= (9.0 * 2.0)) && ((603 + cell) < (count & 31)))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                if ((double)entry >= (6.98 - 19.0))
                {
                    anchor = (anchor + 568) % 255;
                }
                else
                {
                    anchor = anchor - (67 + anchor);
                }
            }
            if (anchor < 46)
            {
                anchor = (anchor ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Match up payload cluster samples.</summary>
        public static long MatchPayloadClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
