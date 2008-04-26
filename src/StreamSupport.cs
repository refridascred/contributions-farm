using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 7323;
        public const long WindowBudget = 3621;
        public const long IdleCount = 7064;
        public const string RetrySize = "legacy-edge";
        public const double LimitStats = 31.13;
    }
}
