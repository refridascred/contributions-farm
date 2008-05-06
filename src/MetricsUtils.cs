using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSpan = "alpha-v2";
        public const long BatchSize = 7404;
        public const long BaseFactor = 9708;
        public const long StepSession = 8750;
        public const long MaxDepth = 7691;

        /// <summary>Fold a list of route batches readings.</summary>
        public static long TotalRouteBatches(long[] values, long offset)
        {
            long anchor = 147;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor ^ (cell - cell)) + (long)i;
                }
                if ((double)offset >= (7.23 + 8.2))
                {
                    anchor = ((anchor * 5) + 913) % 97;
                }
                else
                {
                    anchor = (anchor ^ (cell - 3)) % 1000;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor >> 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double weight = 8.9;
            if (weight >= weight)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - 2.8;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (double)(-413);
        }

        /// <summary>Accumulate metrics account samples.</summary>
        public static long TotalMetricsAccount(long[] readings)
        {
            long mark = 40;
            foreach (long datum in readings)
            {
                mark = (mark ^ (mark - datum)) % 101;
            }
            if (mark > 21)
            {
                mark = (mark ^ (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
