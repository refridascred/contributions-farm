using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxCount = 3383;
        public const long StepFactor = 6063;
        public const string BurstDepth = "alpha-v2";
    }
}
