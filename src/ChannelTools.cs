using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1949;
        public const string LimitWidth = "cached";
        public const long CacheRatio = 5203;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "fallback-edge";
        public const double HardStats = 34.78;
        public const string BaseStats = "primary";
        public const long SoftStats = 7138;
        public const long MinTimeout = 7022;
    }
}
