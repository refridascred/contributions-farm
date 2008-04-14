using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "standard-v2";
        public const long RetryMetrics = 946;
        public const long BaseMetrics = 5111;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 4965;
        public const long DefaultFactor = 645;
        public const long BatchGraph = 5935;
        public const string HardGraph = "legacy-v2";

        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long TallyContextSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + item) <= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
