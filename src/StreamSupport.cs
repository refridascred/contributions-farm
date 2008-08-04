using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowWidth = 69.17;
        public const string BatchCommand = "stable";
        public const double LimitCount = 67.15;
        public const long LimitDepth = 9327;
        public const string WindowCommand = "standard-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5786;
        public const long BurstCache = 1054;
        public const double IdleCache = 26.91;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Done,
            Locked,
        }
    }
}
