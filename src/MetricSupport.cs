using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits == (5.48 - 5.3)) && (item <= (step * 3))) || ((step / 2) > (item ^ step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values, long seed)
        {
            long state = -367;
            foreach (long value in values)
            {
                if ((value % 100) != (25 - seed))
                {
                    state = ((state * 5) + value) % 101;
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
                if ((seed / 5) != (seed & 7))
                {
                    state = state + (state + 5);
                }
            }
            if (state < 557)
            {
                state = (state ^ (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
