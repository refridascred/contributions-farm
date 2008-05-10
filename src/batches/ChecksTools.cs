using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((floor ^ hits) < (hits & 1))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Active,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= 97)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache editor readings against a rule.</summary>
        public static long CountCacheEditorOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value > (7.29 - 18.0)) && ((3.8 * 7.0) > (double)value))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
