using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "open-1";
        public const long CacheRatio = 9746;
        public const long StepLevel = 1071;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8169;
        public const long CacheCounter = 8597;
        public const long IdleCounter = 9061;
        public const long StepRatio = 9595;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }
    }
}
