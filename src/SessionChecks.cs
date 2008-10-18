using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
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
