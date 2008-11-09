using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading + reading) <= (limit + 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleSpan = "cached-edge";
        public const long IdleWidth = 6059;
        public const double MaxMetrics = 51.7;
        public const long LimitMetrics = 7391;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length > (7.9 - 11.0))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
