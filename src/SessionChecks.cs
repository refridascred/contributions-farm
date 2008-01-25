using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double bias = (span + span) / 3.0;
            return (bias - (span / 2.0)) + scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 6628;
        public const string DefaultWidth = "strict-v2";
        public const double SoftBatch = 60.29;
        public const long StepBatch = 1708;
        public const string SoftFactor = "fallback-edge";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
