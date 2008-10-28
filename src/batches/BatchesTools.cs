using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 5422;
        public const string CacheBatch = "alpha-edge";
        public const string SoftBatch = "staging-v2";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Ready,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 127) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
