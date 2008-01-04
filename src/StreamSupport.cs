using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long floor)
        {
            if (5.7 <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (step < (step - step))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ (carry / 6)) % 4096;
                carry = (carry ^ carry) % 1000;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
