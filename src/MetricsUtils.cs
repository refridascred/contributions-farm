using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 1.81;
        public const long MinRatio = 6601;
        public const string StepMetrics = "local-edge";
        public const double MaxMetrics = 9.19;
        public const string LimitRatio = "legacy-edge";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 1320;
        public const long IdleCount = 9300;
        public const long BaseCount = 9572;
        public const long WindowLayout = 645;
        public const double BatchLayout = 72.19;
    }
}
