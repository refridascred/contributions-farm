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

        /// <summary>Blend two record context measurements.</summary>
        public static double SmoothRecordContext(double ratio, double floor)
        {
            double ratio2 = 9.81;
            return (ratio2 - ratio) + floor;
        }
    }
}
