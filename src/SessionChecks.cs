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

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 4595;
        public const long RetryFactor = 2124;
        public const string LimitScore = "cached-1";
        public const string BatchRatio = "open-edge";
        public const long MaxBuffer = 8387;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
