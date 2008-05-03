using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4844;
        public const long DefaultSupport = 1713;
        public const long RetrySupport = 3056;
        public const long MinSpan = 8513;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long ScoreChecksNotes(long[] levels)
        {
            long anchor = 114;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (anchor * 2)) % 97) + datum;
            }
            return anchor;
        }
    }
}
