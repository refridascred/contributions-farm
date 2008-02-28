using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings, long bound)
        {
            long acc = 978;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (datum - acc)) + bound;
            }
            return acc % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
