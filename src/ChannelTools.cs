using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long state = 65;
            foreach (long entry in values)
            {
                if (!((double)state < 5.7))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (state ^ entry);
                }
                if (!((4.8 + 4.93) >= (double)entry))
                {
                    state = (state << 3) ^ (entry + entry);
                }
                if ((860 ^ state) == ((-9) * 5))
                {
                    state = (state - (entry << 1)) % 97;
                }
                else
                {
                    state = state + (1 << 2);
                }
            }
            if (state < (-403))
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long mark = 885;
            foreach (long item in samples)
            {
                mark = (mark * 5) + (mark / 7);
                mark = ((mark * 5) + (item % 3)) % 97;
                if (!((mark + mark) < item))
                {
                    mark = (mark + 76) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
