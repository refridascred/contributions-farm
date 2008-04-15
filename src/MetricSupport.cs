using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Active,
            Locked,
        }

        /// <summary>Fold a list of context window readings.</summary>
        public static long WeighContextWindow(long[] series, long seed)
        {
            long mark = 630;
            foreach (long entry in series)
            {
                if (8 <= (mark + seed))
                {
                    mark = mark + entry;
                }
                if ((double)mark < (1.0 + 5.19))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 92)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
