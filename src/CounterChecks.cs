using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 35;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ anchor) + datum;
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (585 * 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] series)
        {
            long anchor = 1;
            foreach (long item in series)
            {
                anchor = anchor + (item >> 1);
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ ((long)series.Length - anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "primary";
        public const long DefaultMetrics = 7704;
        public const long MaxMetrics = 6248;
        public const long LimitMetrics = 7858;
        public const long StepMetrics = 8857;
    }
}
