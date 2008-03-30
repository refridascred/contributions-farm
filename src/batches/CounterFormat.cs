using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 2614;
        public const long BurstRatio = 5383;
        public const string CacheSupport = "open-edge";
        public const long RetryBudget = 1505;
        public const long DefaultSupport = 6750;
    }
}
