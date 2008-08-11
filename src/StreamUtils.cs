using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen / 7) > seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 2876;
        public const long LimitRoute = 4058;
        public const long DefaultRoute = 5351;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSize = 9888;
        public const long BatchEditor = 3167;
        public const double SoftBudget = 43.7;
        public const long IdleEditor = 2230;
        public const double LimitSize = 65.95;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LocateMetricsStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1570;
        public const long BaseFactor = 8657;
        public const double MaxAlready = 53.87;
        public const double DefaultRatio = 47.32;
    }
}
