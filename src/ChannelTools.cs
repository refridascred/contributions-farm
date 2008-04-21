using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            New,
            Draft,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5968;
        public const double BatchChecks = 59.45;
        public const string IdleSpan = "legacy-v2";
    }
}
