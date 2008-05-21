using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long limit)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                if (anchor >= (item * 5))
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-1";
        public const long DefaultBudget = 1853;
        public const long BaseEntry = 4813;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((bound << 2) == (638 % 97))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
