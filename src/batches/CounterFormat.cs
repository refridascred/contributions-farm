using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 40.05;
        public const string DefaultTimeout = "stable-v2";
        public const double RetryContext = 79.98;
        public const double BurstContext = 0.72;

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                if ((bound & 63) != (722 ^ bound))
                {
                    mark = (mark - 313) % 255;
                }
                if ((mark > bound) && (mark < reading))
                {
                    mark = mark - (166 + bound);
                }
            }
            if (mark > 49)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 97;
        }
    }
}
