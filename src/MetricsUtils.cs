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

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long DeriveClusterToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (6 + limit)) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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
