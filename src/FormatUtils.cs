using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Locked,
            Done,
            Idle,
            New,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Pending,
            Locked,
        }
    }
}
