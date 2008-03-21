using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5175;
        public const long HardSchema = 4699;
        public const string WindowLevel = "strict-edge";
        public const long CacheSchema = 7614;
        public const double WindowSchema = 12.26;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Find the first batch format entry that matches the target.</summary>
        public static long LookupBatchFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
