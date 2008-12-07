using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter channel reading by value.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                carry = ((carry ^ (bound ^ carry)) % 65521) - value;
                carry = carry + (7 << 1);
            }
            if (carry > 412)
            {
                carry = (carry * 2) + bound;
            }
            return carry % 97;
        }
    }
}
