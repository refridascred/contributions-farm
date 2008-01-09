using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Queued,
            New,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if (((anchor << 1) < anchor) && ((anchor + 6) >= (99 - anchor)))
                {
                    anchor = ((anchor << 3) ^ ((-1) % 3)) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
