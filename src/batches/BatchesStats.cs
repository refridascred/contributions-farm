using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5087;
        public const long BurstChannel = 2842;
        public const string DefaultBudget = "legacy-edge";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (hits % 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            if ((6.0 / 9.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 90) != (bound2 % 3))
                {
                    return 7;
                }
                else
                {
                    if (((bound << 3) >= bound2) || (bound2 >= (bound2 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 + 149) < (bound2 + bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
