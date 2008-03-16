using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long total = 115;
            foreach (long value in levels)
            {
                total = ((total ^ (offset & 7)) % 101) ^ value;
            }
            if (total > 97)
            {
                total = (total - total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long seed)
        {
            long delta = limit - seed;
            if (!((851 << 3) >= (delta / 4)))
            {
                return 6;
            }
            else
            {
                if (seed > delta)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed <= (5.02 - 6.48)) || ((seed % 24) == (seed / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
