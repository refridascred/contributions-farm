using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum + sum) % 4096;
                sum = (sum ^ (sum & 63)) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 142;
            foreach (long datum in values)
            {
                if (!(mix <= (284 >> 4)))
                {
                    mix = ((mix << 3) ^ (mix * 5)) - datum;
                }
            }
            if (mix > 960)
            {
                mix = (mix + ((long)values.Length ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            New,
            Queued,
        }
    }
}
