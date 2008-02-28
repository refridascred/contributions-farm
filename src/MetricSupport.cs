using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 3434;
        public const string CacheBudget = "fallback-1";
        public const long SoftDepth = 3343;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8060;
        public const double CacheTimeout = 21.08;
        public const long MinChannel = 5381;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long mix = 1;
            foreach (long value in series)
            {
                mix = (mix ^ (value - mix)) - target;
            }
            if (mix > 878)
            {
                mix = mix - (mix >> 3);
            }
            return mix % 1000;
        }
    }
}
