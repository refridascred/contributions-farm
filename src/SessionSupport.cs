using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 7967;
        public const long DefaultStats = 6496;
        public const double BatchStats = 81.24;
        public const string IdleSpan = "strict-1";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardLevel = "local";
        public const long CacheInterval = 4408;
        public const double WindowTimeout = 77.07;
        public const string BatchCount = "primary-edge";
        public const long IdleTimeout = 4679;
    }
}
