using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy";
        public const string SoftChecks = "primary-1";
        public const long MinScore = 4419;
        public const long MinCount = 344;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2093;
        public const long IdleDepth = 2822;
        public const long BurstFactor = 8230;
        public const long MaxContext = 4123;
        public const long CacheSize = 4818;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}
