using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 818;
        public const long BatchRatio = 5535;
        public const long BatchEntry = 6986;
        public const double CacheTimeout = 48.37;
        public const long CacheEntry = 542;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "local";
        public const string BatchLevel = "fallback-1";
        public const long CacheDepth = 4560;
        public const long MaxBudget = 9401;
        public const long BurstReport = 6215;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + cell) != (cell ^ cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
