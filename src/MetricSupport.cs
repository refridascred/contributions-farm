using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6211;
        public const long WindowCommand = 9561;
        public const string RetryCommand = "fallback";
        public const long HardTimeout = 8276;
        public const double LimitCommand = 60.54;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "cached-1";
        public const long WindowQueue = 6088;
        public const long LimitFactor = 3062;
    }
}
