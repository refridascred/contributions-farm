using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2135;
        public const long HardSize = 3440;
        public const double WindowFilter = 83.6;
        public const double LimitFilter = 5.2;
        public const long MinLevel = 3968;

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
