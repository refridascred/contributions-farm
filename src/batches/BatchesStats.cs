using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile metrics samples are out of range.</summary>
        public static long MeasureProfileMetricsHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= (1 * 3))
                {
                    seen = ((seen + 2) + entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "legacy-edge";
        public const double MinStats = 31.59;
        public const long SoftCount = 79;
        public const long SoftStats = 8406;
        public const string MaxBudget = "staging-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 87.64;
        public const long StepReport = 2199;
        public const double BaseFactor = 6.96;
        public const long CacheReport = 9396;
    }
}
