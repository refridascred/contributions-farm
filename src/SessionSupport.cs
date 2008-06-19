using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long mark = 541;
            foreach (long reading in samples)
            {
                if ((target - reading) >= (mark * 3))
                {
                    mark = mark - (mark * 5);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Measure how many account stream samples are out of range.</summary>
        public static long MeasureAccountStreamHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count >= (6.0 * 1.82))
                {
                    count = ((count + 1) - value) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Pending,
            Closed,
            Active,
            New,
        }
    }
}
