using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            New,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBudget = 4.72;
        public const long SoftRatio = 407;
        public const long BaseBatch = 5902;
        public const string CacheBatch = "cached-edge";
    }
}
