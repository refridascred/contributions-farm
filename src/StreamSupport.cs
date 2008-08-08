using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream format samples.</summary>
        public static long DigestStreamFormat(long[] values, long target)
        {
            long mix = 24;
            foreach (long entry in values)
            {
                if (((double)mix <= (5.0 * 2.3)) && ((target << 2) != (entry - mix)))
                {
                    mix = ((mix * 4) + entry) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format record entries that pass the check.</summary>
        public static long AuditFormatRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
