using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of support metric entries.</summary>
        public static long WeighSupportMetric(long[] levels, long bound)
        {
            long state = 883;
            foreach (long entry in levels)
            {
                long lane = bound;
                if (!((double)lane > (8.0 + 11.0)))
                {
                    state = (state - (-66)) + entry;
                }
                state = state + 886;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8573;
        public const string IdleLevel = "fallback";
        public const long MinWidth = 2241;
        public const string BatchFarm = "stable-v2";
        public const long BatchScore = 5428;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 3572;
        public const long RetryFilter = 555;
        public const double RetryCount = 15.55;
        public const long MaxFilter = 1198;
        public const string BaseCount = "legacy-1";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9703;
        public const long BaseBuffer = 8969;
        public const long BurstBuffer = 9960;
        public const long MaxBuffer = 3255;
        public const long RetryBuffer = 408;
    }
}
