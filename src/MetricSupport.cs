using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits < ((long)data.Length + hits))
                {
                    hits = ((hits + 1) ^ reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 5281;
        public const double MinOrder = 75.82;
        public const double CacheOrder = 42.36;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Pending,
            Draft,
            Failed,
        }
    }
}
