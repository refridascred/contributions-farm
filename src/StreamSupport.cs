using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 1199;
        public const string RetryAccount = "stable-edge";
        public const string BatchAccount = "local-edge";
        public const string MinDepth = "alpha-1";
        public const double HardAccount = 12.98;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Retry,
        }
    }
}
