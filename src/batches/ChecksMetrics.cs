using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8324;
        public const double WindowMetric = 37.45;
        public const long MaxMetric = 2469;

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 3) < (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support cluster entries.</summary>
        public static long ScoreSupportCluster(long[] items)
        {
            long mark = 64;
            foreach (long entry in items)
            {
                mark = (mark - (entry & 15)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long total = 270;
            foreach (long cell in series)
            {
                total = (((total + (total * 4)) % 255) + cell) + limit;
            }
            if (total > 895)
            {
                total = (total - 482) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Iterate the channel stats series from a seed.</summary>
        public static long StepChannelStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (limit - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
