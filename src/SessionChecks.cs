using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 6483;
        public const double DefaultRoute = 6.33;
        public const long StepRoute = 8640;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Dropped,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 68.47;
        public const string StepCount = "staging-edge";
        public const string StepRatio = "staging-v2";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
