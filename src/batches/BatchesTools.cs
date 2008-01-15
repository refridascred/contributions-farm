using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout command samples.</summary>
        public static long FoldLayoutCommand(long[] series, long floor)
        {
            long mark = 312;
            foreach (long reading in series)
            {
                if ((double)reading == (2.8 / 8.0))
                {
                    mark = mark ^ (floor - floor);
                }
            }
            if (mark < 59)
            {
                mark = (mark * 2) + (mark ^ 42);
            }
            return mark % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
