using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!(((double)carry >= (6.59 - 8.0)) && ((double)carry >= (double)offset)))
                {
                    carry = (carry - (carry - (long)i)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ ((long)i * 3)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
