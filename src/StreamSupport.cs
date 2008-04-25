using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseCount = "standard-v2";
        public const long BatchTools = 4489;
        public const double CacheRatio = 18.7;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Closed,
            Dropped,
        }
    }
}
