using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long MeasureEntryFarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 2) - cell) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4790;
        public const long MaxSchema = 2350;
        public const double IdleSchema = 20.37;
        public const long HardSchema = 7445;
        public const double HardSize = 91.03;
    }
}
