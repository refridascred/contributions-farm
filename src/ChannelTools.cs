using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstWidth = 593;
        public const string BatchLevel = "cached";
        public const double CacheCount = 94.71;
        public const long LimitSchema = 1606;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
