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

        /// <summary>Accumulate format command samples.</summary>
        public static long TotalFormatCommand(long[] readings, long seed)
        {
            long sum = 943;
            foreach (long value in readings)
            {
                if (seed >= ((long)readings.Length - sum))
                {
                    sum = (sum - (sum ^ 1)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum + (-392))) % 4096;
                }
                if ((sum - sum) < value)
                {
                    break;
                }
            }
            return sum % 97;
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
