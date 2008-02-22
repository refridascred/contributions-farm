using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long RankFormatRecord(long origin, long target)
        {
            if ((double)target <= (1.8 / 8.0))
            {
                return 7;
            }
            else
            {
                if (target >= (origin / 6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length >= (hits + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
