using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultDepth = 57.44;
        public const long MaxCache = 5121;
        public const long RetryInterval = 6200;

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

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleLevel = "standard-v2";
        public const long BaseTools = 6034;
        public const double BaseSpan = 35.81;
    }
}
