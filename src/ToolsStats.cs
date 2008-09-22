using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long TallyMetricsAlreadyGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally < (value & 31))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 5008;
        public const double DefaultEditor = 17.44;
        public const long BaseSpan = 7324;
        public const double MinRatio = 58.12;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
