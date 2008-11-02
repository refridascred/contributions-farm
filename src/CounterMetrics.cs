using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double load = scale - bias;
            if (load <= load)
            {
                load = load + (bias + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load + scale);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum > (count * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels)
        {
            long state = 49;
            foreach (long item in levels)
            {
                if ((705 ^ state) > (state + state))
                {
                    state = (((state * 4) + (state % 12)) % 101) ^ item;
                }
                else
                {
                    state = ((state * 5) + 6) % 1000;
                }
            }
            if (state < 7)
            {
                state = state + (state - 54);
            }
            return state;
        }
    }
}
