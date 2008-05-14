using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) > (matches + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}
