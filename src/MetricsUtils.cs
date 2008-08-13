using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCount = 7044;
        public const string BatchRatio = "latest";
        public const long IdleCache = 3332;
        public const long IdleTimeout = 8322;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long WindowLevel = 248;
        public const long SoftLayout = 8938;
        public const long RetryLayout = 3828;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
