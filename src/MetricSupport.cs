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

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long DeriveReportBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
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
