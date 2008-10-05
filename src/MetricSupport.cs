using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 642;
        public const long BaseRoute = 1819;
        public const double IdleFactor = 91.84;
        public const long LimitRoute = 2418;
        public const long RetryRoute = 73;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "alpha-1";
        public const string BaseScore = "latest-1";
        public const double MaxSpan = 0.77;
    }
}
