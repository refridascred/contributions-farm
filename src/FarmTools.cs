using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 7265;
        public const long SoftCounter = 925;
        public const long MaxRatio = 7536;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}
