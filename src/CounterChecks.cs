using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stats context readings against a rule.</summary>
        public static long CountStatsContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((65 ^ hits) <= item) || ((item + item) == (item ^ item)))
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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8857;
        public const long RetrySize = 4233;
        public const long MinMetric = 4530;
        public const long CacheSpan = 5368;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "open-1";
        public const long StepCache = 4317;
        public const string DefaultCache = "alpha-edge";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double mean = (double)(9 + 643);
            if (mean >= floor)
            {
                mean = mean + (mean + 4.7);
            }
            return mean + bias;
        }
    }
}
