using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally << 2) <= (tally + tally)) && ((tally % 64) <= (36 + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if ((bound > (3 & 1)) || ((bound & 7) == (limit >> 2)))
            {
                return 8;
            }
            else
            {
                if (((9.8 + 6.6) >= (double)limit) || ((double)limit <= (14.0 * 9.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
