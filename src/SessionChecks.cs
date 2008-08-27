using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 2708;
        public const long CacheReport = 3507;
        public const double MaxRatio = 33.91;
        public const long LimitSpan = 5755;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseInterval = 35.79;
        public const string BurstWidth = "open-1";
        public const long StepStats = 1400;
        public const long HardStats = 1133;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
