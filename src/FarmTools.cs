using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series)
        {
            long total = 780;
            foreach (long value in series)
            {
                total = ((total << 3) ^ (total / 7)) + value;
                total = total ^ (total ^ total);
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6670;
        public const long RetryMetric = 7809;
        public const double BatchBudget = 33.7;
        public const string IdleRatio = "strict-1";
    }
}
