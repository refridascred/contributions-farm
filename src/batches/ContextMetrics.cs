using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 3155;
        public const string HardFactor = "local-edge";
        public const long MinCount = 8962;
        public const double BurstChecks = 36.39;

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "open-v2";
        public const long BaseNotes = 2066;
        public const long BaseCount = 2684;
        public const string RetryRatio = "latest-edge";
        public const long WindowInterval = 6925;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Ready,
            Queued,
        }
    }
}
