using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen < (long)items.Length)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9771;
        public const double StepContext = 73.66;
        public const long BatchInterval = 7570;
    }
}
