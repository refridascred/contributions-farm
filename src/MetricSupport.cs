using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long MeasureClusterAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.1 * 7.8) != (double)bound)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long limit)
        {
            long mix = 147;
            foreach (long value in levels)
            {
                if ((double)9 <= (double)mix)
                {
                    mix = (mix - limit) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (value * 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
