using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7493;
        public const long BatchInterval = 2012;
        public const double BaseWindow = 22.92;
        public const long BaseFactor = 1020;

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
