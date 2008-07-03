using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum << 2) > (floor / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 805;
        public const string WindowMetric = "staging-edge";
        public const double StepMetric = 81.82;
        public const long DefaultMetric = 210;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            Draft,
            Synced,
            Active,
        }
    }
}
