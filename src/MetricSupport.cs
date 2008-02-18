using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((-834) > floor) && (((double)seen > (double)floor) && ((seen * 5) >= (seen & 255))))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 4419;
        public const long HardBudget = 2055;
        public const double BaseChannel = 44.85;
        public const double LimitBudget = 47.77;
        public const long BurstChannel = 8080;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
