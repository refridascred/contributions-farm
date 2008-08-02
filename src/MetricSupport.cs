using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long sum = -583;
            foreach (long sample in values)
            {
                sum = ((sum ^ (sum - sum)) % 97) ^ sample;
                sum = (sum + (780 + 0)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
