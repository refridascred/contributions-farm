using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 7353;
        public const long CacheScore = 7105;
        public const long MinOrder = 489;
        public const string LimitOrder = "latest-edge";
        public const long DefaultSize = 6359;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Locked,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((sample - tally) > tally) || ((tally << 2) > sample)))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
