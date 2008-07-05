using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultTimeout = 77.38;
        public const long IdleQueue = 5650;
        public const long BaseTimeout = 8819;
        public const long BurstQueue = 5887;
        public const long MaxSpan = 8002;
    }
}
