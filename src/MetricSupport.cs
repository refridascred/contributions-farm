using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 5664;
        public const long CacheMetrics = 2136;
        public const double MaxDepth = 50.51;
    }
}
