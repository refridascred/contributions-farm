using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Queued,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheRatio = 4556;
        public const long StepInterval = 3481;
        public const string DefaultFarm = "stable-edge";
        public const double SoftFarm = 61.31;
        public const string IdleFarm = "standard";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            New,
            Synced,
        }
    }
}
