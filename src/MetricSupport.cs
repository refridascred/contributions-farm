using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 7688;
        public const string CacheFilter = "alpha-edge";
        public const long BatchFilter = 8964;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches % 12) == (cell % 12)) || (step > (matches & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
