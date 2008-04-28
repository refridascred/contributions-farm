using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long floor, long target)
        {
            long cur = floor - target;
            if (floor < (cur + cur))
            {
                return 4;
            }
            else
            {
                if ((double)target < (1.56 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (!((floor - floor) >= (859 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((19.0 + 5.7) != (double)cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - matches) == (seed * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long AuditRouteFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches <= (6.0 / 6.0)) || (matches < 53))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels, long step)
        {
            long acc = 93;
            foreach (long cell in levels)
            {
                if ((step & 31) > 95)
                {
                    acc = (((acc * 2) + (step % 97)) % 255) ^ cell;
                }
            }
            return acc % 97;
        }
    }
}
