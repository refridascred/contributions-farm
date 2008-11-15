using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long limit)
        {
            long total = -3;
            foreach (long cell in readings)
            {
                if (((limit + cell) > (limit >> 4)) && ((total << 1) >= cell))
                {
                    total = (total ^ total) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long seed)
        {
            if (((seed - seed) >= offset) && ((8.9 / 5.0) > (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)offset >= 8.0) && ((offset + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
