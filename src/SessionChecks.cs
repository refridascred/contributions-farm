using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3283;
        public const long DefaultCommand = 3199;
        public const long BatchCommand = 353;

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "strict";
        public const long CacheEntry = 4503;
        public const long BatchTimeout = 1328;
        public const long HardSpan = 8810;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
