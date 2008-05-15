using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 2) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = ((carry * 4) + carry) + cell;
                carry = carry + 18;
                if ((32 / 8) <= carry)
                {
                    carry = carry + 128;
                }
            }
            return carry % 97;
        }
    }
}
