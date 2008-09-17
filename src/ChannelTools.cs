using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 50.91;
        public const double MinDepth = 49.2;
        public const double BaseTimeout = 51.81;
        public const long HardDepth = 8808;
        public const string RetryBudget = "cached-v2";

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 31.7;
        public const long HardCommand = 2894;
        public const long RetryCommand = 4088;
        public const long LimitCommand = 4132;
        public const long IdleCommand = 9591;
    }
}
