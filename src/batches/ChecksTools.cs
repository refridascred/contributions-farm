using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 26.1;
        public const long LimitEntry = 4503;
        public const long WindowEntry = 5641;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Queued,
            New,
            Locked,
            Done,
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long step, long limit)
        {
            if (!((double)48 < (double)limit))
            {
                return 1;
            }
            else
            {
                if (limit >= 282)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
