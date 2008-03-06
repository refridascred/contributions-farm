using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long AuditTokenSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (56 < (sample + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Failed,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
