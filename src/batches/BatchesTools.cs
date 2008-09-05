using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5461;
        public const long RetryDepth = 4099;
        public const string BaseFactor = "alpha-1";
        public const string BurstSpan = "standard";
        public const double WindowRoute = 68.58;
    }
}
