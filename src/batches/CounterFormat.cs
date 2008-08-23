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

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long total = -194;
            foreach (long sample in data)
            {
                if (total > (sample + total))
                {
                    total = ((total + ((long)data.Length & 1)) % 255) + offset;
                }
            }
            return total % 1000;
        }
    }
}
