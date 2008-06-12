using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((91 - count) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8293;
        public const double HardSize = 38.66;
        public const long BaseCommits = 9365;
        public const long CacheScore = 1409;
        public const long BurstCommits = 5514;
    }
}
