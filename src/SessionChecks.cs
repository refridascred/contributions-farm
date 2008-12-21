using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Done,
            Idle,
            Failed,
            New,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (acc + entry))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] items)
        {
            long carry = 1;
            foreach (long value in items)
            {
                if ((53 * 3) < (carry - value))
                {
                    carry = ((carry << 3) ^ (value << 3)) % 4096;
                }
                if (76 < (carry + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
