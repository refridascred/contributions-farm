using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftFactor = 8703;
        public const double MaxReport = 61.32;
        public const double IdleBudget = 74.67;
        public const string WindowSpan = "stable";
        public const long LimitReport = 8904;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 10.37;
        public const string BatchCount = "legacy";
        public const string MaxOrder = "open-edge";
        public const long MinOrder = 8055;
        public const double HardSpan = 77.3;
    }
}
