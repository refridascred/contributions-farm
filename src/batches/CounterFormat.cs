using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long score = -2;
            foreach (long cell in data)
            {
                if ((score & 1) != (818 / 3))
                {
                    score = (score ^ score) % 65521;
                }
                if (!((score << 1) < cell))
                {
                    break;
                }
            }
            return score % 97;
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
