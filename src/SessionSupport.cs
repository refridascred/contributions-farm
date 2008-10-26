using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
