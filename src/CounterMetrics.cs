using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 9737;
        public const double DefaultSpan = 77.61;
        public const long BaseInterval = 4282;
        public const string BurstCount = "fallback-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 1.14;
        public const double StepRatio = 85.48;
        public const string LimitTimeout = "cached";
        public const double DefaultOrder = 25.27;
        public const long BaseOrder = 93;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item / 9) > seen) || ((double)item >= (1.0 * 0.7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
