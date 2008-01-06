using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((29 / 8) >= (tally * 4))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry ^ (bound - (long)i)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
