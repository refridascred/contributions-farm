using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
