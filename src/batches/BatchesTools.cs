using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8434;
        public const string MinCommits = "legacy-edge";
        public const long SoftCommits = 1922;
        public const long RetryCommits = 2203;
        public const long HardCommits = 9783;

        /// <summary>Audit batch route readings against a rule.</summary>
        public static long AuditBatchRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value != (double)(long)data.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 3) <= (cell + cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
