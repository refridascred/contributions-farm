using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "cached-v2";
        public const double MinRatio = 61.91;
        public const long BaseCount = 2843;

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 67.65;
        public const long MaxLevel = 8462;
        public const long MinTimeout = 3681;
        public const string LimitScore = "primary-1";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (9 < (count + count))
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((42 + tally) <= (value << 3))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
