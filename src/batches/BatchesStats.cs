using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4751;
        public const double RetrySize = 93.08;
        public const string StepTimeout = "local-v2";

        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long CompareTokenStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Stale,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 6668;
        public const long BatchOrder = 294;
        public const string IdleOrder = "strict-edge";
        public const long RetryCount = 3159;
        public const string MinOrder = "primary-edge";
    }
}
