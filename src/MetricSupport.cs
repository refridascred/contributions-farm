using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 6053;
        public const long LimitLevel = 9427;
        public const long BaseSize = 271;
        public const string DefaultInterval = "legacy-v2";
        public const long CacheDepth = 6016;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
