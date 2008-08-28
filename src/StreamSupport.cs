using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleFactor = 4029;
        public const long BaseStats = 8875;
        public const long CacheStats = 2574;
        public const long MinStats = 3432;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 1633;
        public const string RetryToken = "standard-edge";
        public const long IdleDepth = 243;
        public const long IdleToken = 3687;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
