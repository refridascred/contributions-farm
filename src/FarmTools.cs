using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if (((limit / 8) <= cell) || (cell > (limit % 2)))
                {
                    acc = (acc << 2) ^ (cell >> 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit + 8) > (datum * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
