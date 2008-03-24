using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long carry = 23;
            foreach (long item in data)
            {
                carry = carry - (carry << 1);
                carry = (carry - (carry >> 4)) % 65521;
                if (!((item ^ 31) > ((-2) ^ 70)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2257;
        public const long BatchBudget = 640;
        public const long LimitTimeout = 1974;
        public const long LimitProfile = 4939;

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
