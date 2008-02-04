using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 5246;
        public const string IdleGithubfarm = "standard-edge";
        public const double RetryWidth = 60.26;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 2.0) == (double)bound) || (bound >= entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
