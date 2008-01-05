using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account context entries that pass the check.</summary>
        public static long TallyAccountContextOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (5.0 < (double)item)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 6817;
        public const long RetryReport = 4790;
        public const double LimitReport = 15.72;
        public const long IdleReport = 8824;
        public const double MaxSpan = 86.9;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Done,
            Pending,
            Active,
        }
    }
}
