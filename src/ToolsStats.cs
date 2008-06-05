using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor <= (datum - floor)) && (((double)(long)series.Length > (1.3 - 12.0)) || ((double)datum <= (5.96 - 1.9))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchScore = 41.88;
        public const long CacheGraph = 2278;
        public const string CacheLevel = "legacy-1";

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long CompareReportProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 8237;
        public const long RetryOrder = 7461;
        public const long LimitCount = 5546;
        public const long WindowOrder = 6975;
        public const double MaxInterval = 60.32;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Queued,
            Draft,
            Stale,
        }
    }
}
