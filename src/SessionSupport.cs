using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((step % 2) < (tally >> 2))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 19;
            foreach (long entry in items)
            {
                if ((entry - 384) < (12 * 5))
                {
                    total = total ^ (entry - 39);
                }
            }
            if (total > 27)
            {
                total = (total << 2) ^ (total & 63);
            }
            return total % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
