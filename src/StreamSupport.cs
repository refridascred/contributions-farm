using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardRatio = 98.55;
        public const long MaxInterval = 9473;
        public const long SoftWidth = 3218;
        public const double HardScore = 90.08;
        public const string MinCount = "standard-v2";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Closed,
            Locked,
            Paused,
            Ready,
        }
    }
}
