using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 84;
        public const long BatchScore = 1205;
        public const long DefaultFactor = 8877;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 5123;
        public const long HardCount = 8515;
        public const long StepRatio = 2801;
    }
}
