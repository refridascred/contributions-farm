using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSpan = 29.01;
        public const long HardToken = 1124;
        public const long LimitLevel = 6694;
        public const long IdleRatio = 4566;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8406;
        public const long MinInterval = 745;
        public const long BurstFormat = 8383;
        public const string HardRatio = "staging-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 177;
        public const long HardMetric = 7840;
        public const long LimitSize = 6855;
        public const string StepMetric = "fallback-v2";
        public const long IdleMetric = 681;
    }
}
