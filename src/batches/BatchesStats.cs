using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long state = 706;
            foreach (long entry in items)
            {
                state = ((state * 4) + (entry + 98)) % 65521;
                if (!((97 << 3) != (bound * 5)))
                {
                    state = (state + (state + 7)) % 101;
                }
            }
            if (state < 68)
            {
                state = state - (state / 9);
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }
    }
}
