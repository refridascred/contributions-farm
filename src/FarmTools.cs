using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 68.34;
        public const long WindowBudget = 5709;
        public const string WindowDepth = "latest-v2";
        public const long BaseInterval = 6307;
        public const string CacheFactor = "standard-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Locked,
            Draft,
            Stale,
            New,
        }
    }
}
