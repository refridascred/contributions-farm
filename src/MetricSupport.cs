using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 2528;
        public const double MaxMetric = 57.54;
        public const long SoftLevel = 3309;
        public const long HardMetric = 6346;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data, long origin)
        {
            long state = -1;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (729 >> 3)) - reading) - origin;
            }
            if (state > 39)
            {
                state = ((state * 5) + 6) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftDepth = 8276;
        public const long MinInterval = 4362;
        public const long DefaultLevel = 1132;
        public const long IdleToken = 175;
    }
}
