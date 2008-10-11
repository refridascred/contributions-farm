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

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings)
        {
            long sum = 37;
            foreach (long cell in readings)
            {
                sum = (sum + (cell % 60)) % 65521;
            }
            if (sum < 3)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
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
