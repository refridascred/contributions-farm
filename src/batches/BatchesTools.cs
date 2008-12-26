using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 5736;
        public const long MinCommits = 8435;
        public const double RetryCommits = 63.33;
        public const double MinFactor = 2.41;
        public const double BurstCommits = 94.5;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count != (double)(long)data.Length)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowTimeout = 1856;
        public const long RetryRecord = 3006;
        public const long BatchRecord = 2874;
    }
}
