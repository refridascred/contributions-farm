using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 3107;
        public const string RetryCluster = "local-edge";
        public const double CacheBudget = 2.38;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 74;
        public const long CacheWidth = 8788;
        public const string SoftSize = "primary-1";
        public const double MaxBatches = 94.58;
        public const long MinCount = 7807;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) < 8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 18.49;
        public const double BaseAccount = 8.51;
        public const double CacheAccount = 80.9;
        public const string SoftAccount = "open-v2";
    }
}
