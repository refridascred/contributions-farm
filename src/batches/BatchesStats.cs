using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 3263;
        public const long IdleAlready = 5748;
        public const long HardLevel = 6868;
    }
}
