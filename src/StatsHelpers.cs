using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a context payload reading by value.</summary>
        public static long LookupContextPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target < (0.22 * 4.3))
                {
                    mix = (mix << 2) ^ (target + target);
                    mix = ((mix << 3) ^ mix) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long anchor = 28;
            foreach (long value in values)
            {
                if (((step + anchor) == (step << 2)) && ((step & 63) == (value / 5)))
                {
                    anchor = anchor - (anchor % 10);
                }
            }
            if (anchor < 12)
            {
                anchor = anchor + (step % 64);
            }
            return anchor;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double mean = (double)(360 + 597);
            if (mean > (double)62)
            {
                mean = (mean + floor) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (5.0 * 11.0)) - (double)(long)i;
            }
            return mean + (double)914;
        }
    }
}
