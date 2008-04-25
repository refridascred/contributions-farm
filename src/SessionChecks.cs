using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 1492;
        public const double SoftEditor = 47.27;
        public const string CacheScore = "local";

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitWidth = "alpha-v2";
        public const long BurstBatches = 8207;
        public const double SoftBatches = 69.29;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long total = 870;
            foreach (long item in data)
            {
                if (9.5 < (double)origin)
                {
                    total = (((total << 2) ^ (total * 4)) % 255) ^ item;
                }
            }
            return total;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Draft,
            Done,
        }
    }
}
