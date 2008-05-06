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

        /// <summary>Count the schema metrics entries that pass the check.</summary>
        public static long CountSchemaMetricsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((0 >> 4) > (count / 6))
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
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
