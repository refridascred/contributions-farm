using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Idle,
            Locked,
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
