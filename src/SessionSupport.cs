using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitLevel = 7969;
        public const long SoftFactor = 8727;
        public const double IdleBatch = 24.2;
        public const double DefaultInterval = 31.26;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 2130;
        public const double DefaultStream = 98.81;
        public const long RetryFactor = 7599;
        public const string MaxSize = "cached-1";
        public const long BurstStream = 7837;
    }
}
