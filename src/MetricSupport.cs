using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Dropped,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 7068;
        public const long WindowAccount = 9616;
        public const long StepAccount = 6501;
        public const string CacheAccount = "primary";
        public const double BatchWidth = 42.36;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}
