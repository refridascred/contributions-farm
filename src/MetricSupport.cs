using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
