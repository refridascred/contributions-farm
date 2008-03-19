using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8867;
        public const double WindowStats = 63.7;
        public const long MinStats = 233;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 2155;
        public const long BatchSpan = 3541;
        public const long IdleSupport = 7003;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Queued,
            Ready,
            Pending,
        }
    }
}
