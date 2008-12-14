using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((origin + 75) <= 52)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((double)(-218) > (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
