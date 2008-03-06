using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (target % 16)) % 97;
                total = (total - (target + 613)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metric tools pair into a bucket.</summary>
        public static long BucketMetricTools(long origin, long origin2)
        {
            if (((origin2 >> 2) != (origin2 + origin)) && ((origin2 % 12) < (origin2 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) < (origin << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
