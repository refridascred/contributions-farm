using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9374;
        public const string LimitPayload = "local";
        public const double MaxPayload = 38.52;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long anchor = -675;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (cell * 5)) - limit;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
