using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Closed,
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long mark = -321;
            foreach (long item in samples)
            {
                mark = ((mark + (offset % 7)) % 4096) + item;
                mark = (mark ^ (offset * 3)) % 101;
            }
            return mark % 1000;
        }
    }
}
