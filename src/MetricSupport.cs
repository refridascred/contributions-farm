using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "alpha-1";
        public const long BurstQueue = 9590;
        public const double CacheWidth = 59.44;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long step)
        {
            long next = limit + step;
            if ((step * 5) >= limit)
            {
                return 7;
            }
            else
            {
                if ((step + 6) < next)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
