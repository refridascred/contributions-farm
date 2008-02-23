using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long BatchRatio = 4497;
        public const string MaxGraph = "strict-1";
        public const long SoftCount = 105;

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 82.29;
        public const string CacheRoute = "stable-edge";
        public const string HardRoute = "alpha";
        public const string MinDepth = "latest-v2";
        public const double MaxSpan = 60.15;

        /// <summary>Audit githubfarm graph readings against a rule.</summary>
        public static long MeasureGithubfarmGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + (long)levels.Length) <= hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
