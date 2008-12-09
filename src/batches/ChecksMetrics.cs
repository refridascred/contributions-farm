using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every filter githubfarm entry stays within the limit.</summary>
        public static bool VerifyFilterGithubfarmLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5107;
        public const double WindowInterval = 92.54;
        public const long BaseGraph = 6094;
        public const long SoftBudget = 4611;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 405;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + (mix * 3)) % 97) + datum;
                if (!(floor < (mix % 7)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample > 2.1)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "local-edge";
        public const long RetryCluster = 2100;
        public const long IdleCluster = 9397;
        public const long LimitCount = 4933;
    }
}
