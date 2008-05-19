using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound >> 3) >= bound)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 1) < 6) && !((2.64 - 7.0) < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSpan = 57.01;
        public const string MaxOrder = "cached-v2";
        public const long MinOrder = 5567;
        public const long HardOrder = 7529;
    }
}
