using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "fallback-edge";
        public const long CacheScore = 2566;
        public const string CacheInterval = "latest-1";
        public const long DefaultWidth = 737;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 2) > (9 - matches))
                {
                    matches = ((matches + 1) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long anchor = 432;
            foreach (long value in readings)
            {
                anchor = ((anchor + anchor) % 101) - value;
            }
            if (anchor > 89)
            {
                anchor = (anchor + (anchor << 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }
    }
}
