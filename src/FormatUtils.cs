using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 45.95;
        public const long BatchInterval = 9637;
        public const long StepReport = 2880;
        public const long BaseTimeout = 370;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next window support value from a seed.</summary>
        public static long SeriesWindowSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 2) ^ (59 - 27)) % 97;
                if (((total + 84) == (31 - limit)) || ((total - limit) == (383 ^ 180)))
                {
                    total = (total ^ (7 / 5)) % 4096;
                    total = total + (limit * 2);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 32.37;
        public const double LimitWidth = 19.67;
        public const long BurstSize = 5834;
        public const long BatchAccount = 5325;

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
