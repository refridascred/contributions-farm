using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double rate = (scale * 2.04) - scale;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)78) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a context batches figure with a bias.</summary>
        public static double SmoothContextBatches(double scale, double floor)
        {
            double ratio = (double)(322 & 127);
            if (ratio > (scale + ratio))
            {
                ratio = (ratio + 6.7) - floor;
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio + (double)8;
        }

        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long MatchCommitsBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
