using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "latest-1";
        public const long DefaultBatch = 4756;
        public const long RetryWidth = 6660;
        public const long StepSpan = 3227;
        public const long BaseBatch = 8080;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinInterval = "primary-v2";
        public const long RetryBudget = 3515;
        public const string BaseOrder = "local-1";
    }
}
