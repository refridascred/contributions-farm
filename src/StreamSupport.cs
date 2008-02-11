using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinTimeout = 5758;
        public const double IdleSpan = 95.59;
        public const double BurstProfile = 43.74;
        public const long CacheTimeout = 7657;
        public const long DefaultProfile = 3152;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
