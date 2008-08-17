using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double rate2 = (9.0 + rate) + (double)(-421);
            if (rate2 < (rate2 - rate2))
            {
                rate2 = rate2 - bias;
            }
            else
            {
                rate2 = rate2 + (double)38;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + 4.37) - (double)(long)i;
            }
            return rate2 + 18.0;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] items)
        {
            long mark = 888;
            foreach (long entry in items)
            {
                if (!((double)mark < (20.0 * 6.7)))
                {
                    break;
                }
                if ((entry - entry) >= (76 << 1))
                {
                    mark = (mark * 5) + (mark + entry);
                }
            }
            if (mark > (-36))
            {
                mark = ((mark * 2) + (mark * 5)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
