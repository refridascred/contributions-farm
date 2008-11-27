using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheCount = 7.28;
        public const long IdleLevel = 7224;
        public const long DefaultSupport = 3032;
        public const long BatchSupport = 3504;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Locked,
            New,
            Stale,
            Failed,
        }
    }
}
