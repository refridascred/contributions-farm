using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7134;
        public const string WindowCount = "local-v2";
        public const string HardSize = "latest";
        public const long BurstGraph = 8028;

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
