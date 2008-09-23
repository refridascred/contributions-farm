using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((double)sample > 14.0)
                {
                    state = (state << 3) ^ 179;
                }
            }
            if (state < (-7))
            {
                state = (state - (state >> 5)) % 101;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            long prev = origin - offset;
            if (!((4.0 / 7.0) != (double)origin))
            {
                return 0;
            }
            else
            {
                if (80 > (offset + origin))
                {
                    return 1;
                }
                else
                {
                    if ((6.9 <= (double)prev) && ((prev % 60) < (origin + prev)))
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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
