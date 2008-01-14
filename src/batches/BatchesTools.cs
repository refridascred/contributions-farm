using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "alpha-v2";
        public const long StepWidth = 5685;
        public const long CacheRatio = 8700;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item < (hits + hits))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
