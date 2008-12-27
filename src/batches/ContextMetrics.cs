using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const long CacheCount = 1996;
        public const long MinStats = 3981;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count >> 5) < count)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
