using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 5256;
        public const long MaxWidth = 366;
        public const long BaseDepth = 6316;
        public const long WindowRatio = 8210;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Failed,
            Synced,
            Pending,
            Done,
        }
    }
}
