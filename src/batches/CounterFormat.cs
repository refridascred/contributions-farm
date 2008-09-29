using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long state = 7;
            foreach (long item in samples)
            {
                if ((item + item) < (511 + item))
                {
                    state = state + (item + item);
                }
                else
                {
                    state = state ^ (item + state);
                }
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 207;
            foreach (long reading in levels)
            {
                mix = (mix + mix) ^ reading;
            }
            return mix;
        }
    }
}
