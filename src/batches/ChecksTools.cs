using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + seed) == (reading ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Done,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryFactor = 83.65;
        public const long BurstCommand = 8677;
        public const long StepTimeout = 220;
        public const long MinSize = 3446;
    }
}
