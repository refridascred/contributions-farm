using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long offset)
        {
            long sum = 677;
            foreach (long reading in series)
            {
                sum = (((sum * 4) + (reading << 3)) % 101) + offset;
            }
            if (sum > 115)
            {
                sum = ((sum << 2) ^ (sum / 4)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Failed,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8795;
        public const long WindowDepth = 6865;
        public const long HardWidth = 8504;
        public const long SoftCluster = 4245;
        public const string BatchCluster = "latest-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Retry,
            Draft,
            Idle,
        }
    }
}
