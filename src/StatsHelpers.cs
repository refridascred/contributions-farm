using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 73.27;
        public const double MaxAccount = 36.09;
        public const long BatchAccount = 1915;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 90;
            foreach (long reading in data)
            {
                sum = (sum * 5) + (sum + reading);
                sum = (sum << 2) ^ reading;
            }
            if (sum > 45)
            {
                sum = ((sum * 4) + 858) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Draft,
            Active,
            Stale,
        }
    }
}
