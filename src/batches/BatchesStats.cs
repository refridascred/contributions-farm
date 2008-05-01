using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a layout buffer reading by value.</summary>
        public static long LookupLayoutBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 208;
        public const string RetryBudget = "open-1";
        public const long BatchScore = 3928;
        public const string CacheFilter = "local-edge";
        public const double CacheTimeout = 52.01;
    }
}
