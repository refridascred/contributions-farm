using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double drift = offset + offset;
            if (drift > (offset * 2.8))
            {
                drift = drift - (double)65;
            }
            return drift - ratio;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 13.93;
        public const long MaxSize = 1684;
        public const long MaxContributi = 6582;
        public const long HardContributi = 9865;
        public const long RetryContributi = 8739;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (matches >> 3))
                {
                    matches = ((matches + 3) + item) - step;
                }
            }
            return matches;
        }
    }
}
