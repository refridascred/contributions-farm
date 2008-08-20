using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long limit)
        {
            long result = 713;
            foreach (long cell in items)
            {
                if ((limit + cell) > (result + limit))
                {
                    result = result - cell;
                }
                if ((double)result == (2.2 * 0.1))
                {
                    break;
                }
            }
            return result % 97;
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
