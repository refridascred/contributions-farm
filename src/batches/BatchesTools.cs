using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already stream samples are out of range.</summary>
        public static long CountAlreadyStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((7.7 * 2.3) == (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long limit)
        {
            long total = 1;
            foreach (long datum in data)
            {
                total = (total + (limit ^ limit)) ^ datum;
            }
            return total;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
