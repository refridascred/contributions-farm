using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading + result)) + limit;
            }
            return result % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches >= (19.0 / 8.0))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long AuditAlreadyFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + matches) <= (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 146;
        public const double StepSpan = 63.97;
        public const string CacheSpan = "strict-v2";
    }
}
