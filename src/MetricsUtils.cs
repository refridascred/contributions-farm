using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.92 * 8.1) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long limit)
        {
            if (80 <= (offset - (-2)))
            {
                return 8;
            }
            else
            {
                if (8.92 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (!(limit >= (offset << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.0 > (double)(long)series.Length) && ((hits & 15) < hits))
                {
                    hits = ((hits + 3) + item) + offset;
                }
            }
            return hits;
        }
    }
}
