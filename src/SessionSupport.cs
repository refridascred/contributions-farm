using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally % 10) > (value + 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long carry = -232;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) > (carry / 7))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = carry - 28;
                }
            }
            return carry % 4096;
        }
    }
}
