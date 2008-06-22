using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "open-edge";
        public const long MinSpan = 5374;
        public const string DefaultChecks = "standard-edge";
        public const long MinRatio = 5906;
        public const double BatchCount = 15.62;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 2541;
        public const long SoftFactor = 3138;
        public const long RetryWidth = 2998;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Draft,
            Queued,
        }
    }
}
