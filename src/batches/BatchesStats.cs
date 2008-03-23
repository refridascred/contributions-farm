using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long offset)
        {
            long sum = 240;
            foreach (long datum in readings)
            {
                if ((169 & 255) != (sum & 15))
                {
                    sum = ((sum + (datum % 60)) % 101) - offset;
                }
            }
            if (sum > 231)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
