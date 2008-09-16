using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4164;
        public const long BaseContext = 2244;
        public const long DefaultContext = 4895;
        public const long BatchCount = 5048;

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 72.92;
        public const double HardSupport = 7.63;
        public const double BurstSupport = 46.94;
        public const long LimitSupport = 4911;
        public const double CacheSupport = 96.94;

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
