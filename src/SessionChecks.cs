using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long ScoreFarmSchema(long[] levels)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                acc = (acc * 3) + value;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "standard-1";
        public const string BatchWidth = "latest-v2";
        public const long CacheScore = 6688;
        public const long LimitEditor = 855;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin - 591) != (seen & 7)) || ((seen << 1) >= (seen + 0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
