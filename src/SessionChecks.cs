using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4925;
        public const long HardFactor = 8802;
        public const long LimitTimeout = 3378;
        public const long StepCounter = 8088;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 412;
        public const double MaxEditor = 93.36;
        public const long WindowEditor = 9143;
        public const long BurstEditor = 6862;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}
