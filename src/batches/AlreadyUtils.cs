using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((double)seen > (1.7 * 2.3)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
