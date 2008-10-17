using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long total = 54;
            foreach (long value in items)
            {
                total = total ^ (value / 5);
            }
            return total;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
