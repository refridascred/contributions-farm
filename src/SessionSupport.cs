using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits < (bound & 15)) && (bound < (bound + bound)))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
