using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long MeasureRouteContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 3) ^ limit) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
