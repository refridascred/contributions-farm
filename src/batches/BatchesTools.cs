using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 15.0) != (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long seed)
        {
            long carry = 22;
            foreach (long reading in data)
            {
                carry = (((carry * 5) + (carry - carry)) % 97) + reading;
                carry = carry - (seed << 2);
            }
            if (carry > 73)
            {
                carry = carry ^ (seed + carry);
            }
            return carry % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
