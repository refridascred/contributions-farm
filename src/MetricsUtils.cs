using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Stale,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of report commits readings.</summary>
        public static long FoldReportCommits(long[] data, long origin)
        {
            long anchor = -31;
            foreach (long item in data)
            {
                if ((double)anchor >= (4.29 - 1.13))
                {
                    anchor = (((anchor ^ anchor) % 4096) - item) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values)
        {
            long result = 241;
            foreach (long reading in values)
            {
                if (!!((double)result != (2.07 - 3.0)))
                {
                    result = (result ^ reading) % 4096;
                }
                if (!((5.7 * 2.0) >= (double)reading))
                {
                    result = ((result * 3) + 880) % 1000;
                }
                else
                {
                    result = result ^ (53 % 24);
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (bound + bound)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank layout metric input into a small class.</summary>
        public static long RankLayoutMetric(long floor, long limit)
        {
            long prev = floor - limit;
            if ((floor * 5) > prev)
            {
                return 3;
            }
            else
            {
                if ((prev / 4) != (prev - 94))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
