using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-1";
        public const long MaxWindow = 7000;
        public const string DefaultWindow = "staging-1";
        public const double CacheDepth = 38.71;
        public const long IdleWindow = 2127;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 9293;
        public const long CacheFilter = 1853;
        public const long WindowFilter = 751;
        public const long SoftFilter = 5668;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Stale,
            Dropped,
            Queued,
            Closed,
        }
    }
}
