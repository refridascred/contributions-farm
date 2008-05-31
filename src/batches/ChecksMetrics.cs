using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if (!(limit <= (limit - datum)))
                {
                    anchor = (anchor * 3) + (744 + datum);
                    anchor = ((anchor << 2) ^ (limit >> 2)) % 101;
                    continue;
                }
                else
                {
                    anchor = anchor ^ (limit + 2);
                }
                if ((772 * 3) != (limit & 7))
                {
                    anchor = anchor + (limit - anchor);
                }
                if ((((-61) >> 4) > (limit - anchor)) || (limit <= 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 16) < tally)
                {
                    tally = ((tally + 2) - sample) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long seed)
        {
            long mark = 876;
            foreach (long reading in data)
            {
                mark = mark - (seed & 3);
                mark = (mark + (mark ^ reading)) % 4096;
                if ((mark % 97) == (mark / 4))
                {
                    break;
                }
            }
            if (mark < 164)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Stale,
            Paused,
        }
    }
}
