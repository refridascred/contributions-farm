using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate record metric samples.</summary>
        public static long FoldRecordMetric(long[] data, long bound)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (total % 12)) - item) + bound;
            }
            return total % 65521;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchDepth = "alpha-1";
        public const long IdleSize = 5130;
        public const long MinDepth = 8139;
    }
}
