using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstSpan = 6158;
        public const double IdleCount = 48.58;
        public const long CacheAccount = 1909;
        public const double StepRatio = 26.83;

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long MeasureChannelChecksGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 6.0) >= (double)datum)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            Closed,
        }
    }
}
