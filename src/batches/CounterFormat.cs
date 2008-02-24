using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Ready,
            New,
            Locked,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheFactor = 26.03;
        public const long LimitWidth = 4335;
        public const long WindowQueue = 9087;
        public const double DefaultFactor = 59.52;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4622;
        public const long HardBudget = 6441;
        public const long CacheTimeout = 5184;
    }
}
