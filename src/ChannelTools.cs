using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 4168;
        public const long RetryAlready = 9167;
        public const long MinAlready = 8883;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Pending,
            New,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
