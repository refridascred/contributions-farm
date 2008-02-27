using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step > (8.3 * 5.46))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 4) + step;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "strict-v2";
        public const long CacheInterval = 7385;
        public const double BurstInterval = 9.83;
        public const string RetryBatch = "legacy-v2";

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
