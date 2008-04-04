using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (((double)anchor != (1.49 / 4.0)) && ((double)target != (20.0 + 7.0)))
                {
                    anchor = anchor ^ (anchor - target);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Stale,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8728;
        public const long DefaultMetric = 4248;
        public const string LimitMetric = "stable-1";
        public const double LimitInterval = 86.04;
        public const long DefaultSpan = 7578;
    }
}
