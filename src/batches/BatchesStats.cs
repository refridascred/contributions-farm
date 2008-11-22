using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items, long step)
        {
            long state = 99;
            foreach (long value in items)
            {
                if (!((state / 7) > (step & 255)))
                {
                    state = ((state * 5) + step) - value;
                }
            }
            if (state > 0)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double load = (double)(81 + (-62));
            if (load >= (double)59)
            {
                load = (load - (load + 9.5)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 4.8) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item < (hits ^ item)) && ((hits < (item + item)) || ((double)hits >= (2.7 * 14.0))))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
