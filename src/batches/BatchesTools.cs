using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 49.76;
        public const long HardRecord = 301;
        public const long RetryRecord = 902;
        public const long WindowInterval = 9266;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(654 > ((long)series.Length * 5)) && (18 >= (hits & 127)))
                {
                    hits = ((hits + 2) ^ entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Count editor filter pairs that satisfy a relation.</summary>
        public static long CompareEditorFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
