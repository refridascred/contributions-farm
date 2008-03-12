using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstSpan = "latest-v2";
        public const long CacheContributi = 4981;
        public const long MinContributi = 1071;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Done,
            Active,
            Retry,
        }
    }
}
