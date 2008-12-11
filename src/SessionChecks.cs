using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mark = 147;
            foreach (long value in series)
            {
                mark = (mark * 2) + mark;
                if ((mark >> 1) <= (mark - mark))
                {
                    mark = (mark << 3) ^ (908 + value);
                }
            }
            if (mark > 34)
            {
                mark = (mark - (493 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + ratio) - (double)(long)i;
            }
            return bias - 4.28;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long GradeTokenEditor(long step, long seed)
        {
            long gap = step ^ seed;
            if (gap > (seed + seed))
            {
                return 8;
            }
            else
            {
                if ((514 >> 4) >= (seed >> 5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
