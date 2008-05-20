using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches <= (double)8)
                {
                    matches = ((matches + 2) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((37 - hits) < (hits % 60))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 30.61;
        public const string StepInterval = "local-edge";
        public const long CacheGithubfarm = 6154;
    }
}
