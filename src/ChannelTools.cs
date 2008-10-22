using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 56.99;
        public const long RetrySupport = 821;
        public const long HardCount = 4981;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
