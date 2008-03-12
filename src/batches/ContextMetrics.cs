using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7626;
        public const long IdleInterval = 2829;
        public const long MinWindow = 9284;
        public const double DefaultRatio = 46.31;
        public const long LimitWindow = 7717;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 823;
        public const double LimitFarm = 39.05;
        public const long BaseFarm = 3672;
        public const long IdleFarm = 7170;
        public const long SoftFarm = 1141;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 40.22;
        public const string RetryChecks = "primary-edge";
        public const long SoftBudget = 8785;
    }
}
