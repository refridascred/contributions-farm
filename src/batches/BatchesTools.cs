using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - value) > (offset - offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
