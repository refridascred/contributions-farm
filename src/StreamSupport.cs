using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1825;
        public const long MinDepth = 4093;
        public const string LimitSize = "latest-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 73.72;
        public const long IdleLevel = 6837;
        public const long BurstRoute = 8775;
        public const long MinWidth = 2280;
    }
}
