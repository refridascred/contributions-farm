using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.0 * 7.0) >= (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 700;
            foreach (long value in levels)
            {
                sum = ((sum << 2) ^ (34 >> 1)) ^ value;
            }
            return sum;
        }
    }
}
