using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((6.0 / 4.0) == (double)count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
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
