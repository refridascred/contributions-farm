using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(-3) != (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((limit & 127) != (matches - matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 63;
        public const long MaxMetrics = 5322;
        public const double BaseFactor = 93.36;
        public const long MaxLevel = 2117;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
