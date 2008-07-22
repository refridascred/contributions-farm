using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = score + (seed + seed);
                if ((double)item > 6.0)
                {
                    score = (score - (seed / 7)) % 1000;
                }
                else
                {
                    score = score + score;
                }
                if (score >= (item * 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 45) < (hits & 255))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
