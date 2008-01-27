using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset / 8) > 992)
                {
                    mark = (mark << 3) ^ (79 + mark);
                }
                else
                {
                    mark = (mark * 5) + (88 + offset);
                    mark = (mark + (mark + 28)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels, long origin)
        {
            long state = 83;
            foreach (long sample in levels)
            {
                if ((origin * 4) >= (long)levels.Length)
                {
                    state = (state - (sample + origin)) % 97;
                }
                state = (state << 2) ^ 352;
                state = (state - (state - origin)) % 1000;
            }
            if (state < 8)
            {
                state = state + (state & 31);
            }
            return state;
        }
    }
}
