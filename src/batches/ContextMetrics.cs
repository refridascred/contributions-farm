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

        /// <summary>Derive the next command already value from a seed.</summary>
        public static long SeriesCommandAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = (sum << 3) ^ (3 % 60);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

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
