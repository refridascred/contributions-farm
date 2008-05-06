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

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long anchor = 87;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + ((long)values.Length * 2)) - limit;
                anchor = (anchor + (cell + 26)) % 1000;
            }
            if (anchor > 842)
            {
                anchor = ((anchor * 3) + anchor) % 97;
            }
            return anchor;
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
