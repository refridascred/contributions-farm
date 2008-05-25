using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "latest";
        public const double LimitBuffer = 36.77;
        public const long HardBuffer = 5388;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Dropped,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
