using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (5 <= (origin & 1))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Digest a series of commits counter entries.</summary>
        public static long DigestCommitsCounter(long[] values, long offset)
        {
            long carry = 93;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - (166 + offset)) - (long)i;
                    carry = ((carry << 3) ^ (carry >> 4)) % 101;
                }
                if ((offset * 2) <= (offset + 722))
                {
                    carry = (carry + value) % 255;
                }
            }
            return carry;
        }
    }
}
