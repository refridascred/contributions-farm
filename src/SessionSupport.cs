using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
