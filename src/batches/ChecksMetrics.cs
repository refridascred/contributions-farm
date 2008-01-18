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

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
