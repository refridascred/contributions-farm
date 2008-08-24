using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
