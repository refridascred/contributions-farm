using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)1) + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 3566;
        public const long DefaultFactor = 4476;
        public const long CacheSpan = 9494;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
