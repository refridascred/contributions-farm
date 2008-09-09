using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= (sample >> 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
