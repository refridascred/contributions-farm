using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long limit)
        {
            long mark = 675;
            foreach (long value in levels)
            {
                mark = ((mark + (limit + limit)) % 97) + value;
                if (mark >= ((-9) ^ limit))
                {
                    mark = (mark - (limit - limit)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (limit / 9)) % 97;
                }
            }
            if (mark > 51)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            if ((6 >> 1) < (99 - offset))
            {
                return 1;
            }
            else
            {
                if ((8.96 - 1.9) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((4.28 * 7.0) != (double)offset) && ((offset & 127) != (offset ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (origin >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
