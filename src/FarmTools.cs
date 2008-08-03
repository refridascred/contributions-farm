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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}
