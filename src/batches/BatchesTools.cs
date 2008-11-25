using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next filter order value from a seed.</summary>
        public static long SeriesFilterOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((bound - bound) < (cell & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
