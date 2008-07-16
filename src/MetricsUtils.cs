using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseLevel = 3.39;
        public const long SoftMetric = 9816;
        public const double IdleMetric = 57.75;
        public const long StepFactor = 5148;
        public const long BurstBudget = 4307;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long result = 129;
            foreach (long sample in items)
            {
                result = (((result - (result << 3)) % 1000) ^ sample) + target;
            }
            return result;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
