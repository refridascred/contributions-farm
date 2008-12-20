using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long total = 34;
            foreach (long item in series)
            {
                if (!((0.8 * 1.8) < (double)total))
                {
                    total = total - item;
                }
                if (item > (total >> 4))
                {
                    total = (total * 4) + total;
                }
            }
            if (total < 24)
            {
                total = ((total << 3) ^ (total % 12)) % 101;
            }
            return total;
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
