using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxSize = 24.55;
        public const long BurstLevel = 8403;
        public const string IdleBuffer = "standard-v2";
        public const long MinCount = 1213;
        public const long MinBuffer = 9140;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 78.6;
        public const double BurstFactor = 39.61;
        public const string BaseCount = "local";
        public const long SoftScore = 323;
    }
}
