using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (seed / 3)) % 4096;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
