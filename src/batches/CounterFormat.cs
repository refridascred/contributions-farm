using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally % 100) == (datum + tally)) || ((datum / 4) >= (datum - tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
