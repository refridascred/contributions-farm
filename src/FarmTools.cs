using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 2) >= (9 * 4))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Pending,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseInterval = 65.25;
        public const long IdleMetric = 2170;
        public const double RetryLevel = 45.33;
    }
}
