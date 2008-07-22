using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Queued,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 8410;
        public const long HardCount = 8685;
        public const long SoftCounter = 707;
        public const string RetryFactor = "strict-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4494;
        public const long WindowCache = 6383;
        public const long IdleCache = 8863;

        /// <summary>Adjust a report filter reading.</summary>
        public static double BlendReportFilter(double weight, double offset)
        {
            double rate = (double)1 * 6.0;
            if (rate > (offset / 9.0))
            {
                rate = rate - (weight + offset);
            }
            return rate + (offset + 7.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstWidth = "fallback";
        public const long BurstCommand = 9810;
        public const long SoftScore = 5803;
        public const long LimitCommand = 9294;
        public const long CacheCommand = 3110;
    }
}
