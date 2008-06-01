using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long limit)
        {
            if (((limit % 12) == (floor >> 5)) || ((double)floor >= (5.2 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) <= (floor + 680))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of githubfarm route readings.</summary>
        public static long CombineGithubfarmRoute(long[] data, long step)
        {
            long total = 52;
            foreach (long item in data)
            {
                if (!((item - 7) > (step / 9)))
                {
                    total = (total + (item / 2)) % 65521;
                }
                if (12.0 > (double)step)
                {
                    total = ((total << 2) ^ item) % 101;
                }
                else
                {
                    total = (total << 2) ^ (total + step);
                }
            }
            if (total > 4)
            {
                total = ((total * 2) + step) % 255;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long origin)
        {
            long anchor = 80;
            foreach (long cell in values)
            {
                if ((1.99 / 7.0) != (double)cell)
                {
                    anchor = (anchor - (anchor << 2)) - origin;
                }
            }
            return anchor;
        }
    }
}
