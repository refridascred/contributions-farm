using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 60) >= (matches * 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Iterate the checks batch series from a seed.</summary>
        public static long SeriesChecksBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((10.0 / 2.0) <= (double)origin)
                {
                    state = (state + (3 ^ origin)) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
