using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long target2)
        {
            if ((target2 >> 5) > target)
            {
                return 3;
            }
            else
            {
                if ((5.46 * 4.29) != (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target) > target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
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
