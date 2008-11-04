using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Draft,
            Closed,
            Idle,
            New,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "local-1";
        public const long BurstRatio = 9889;
        public const long MaxTimeout = 9132;
        public const long MaxSchema = 4031;
        public const long MinSchema = 2388;
    }
}
