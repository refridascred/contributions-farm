using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(hits < (entry ^ entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
