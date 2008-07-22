using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 1) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] levels, long limit)
        {
            long carry = 91;
            foreach (long sample in levels)
            {
                carry = (carry - sample) % 4096;
                if ((limit & 1) == (limit ^ sample))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry * 5) + (916 & 63);
                }
            }
            if (carry > 0)
            {
                carry = carry + (carry / 8);
            }
            return carry;
        }
    }
}
