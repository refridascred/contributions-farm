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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
