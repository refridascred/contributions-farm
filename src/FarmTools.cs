using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Locked,
            Done,
            Queued,
            Active,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3821;
        public const double HardContributi = 57.11;
        public const double RetryWidth = 83.56;
    }
}
