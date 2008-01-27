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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell < (400 * 5)) || !((18.0 * 10.0) <= (double)cell))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
