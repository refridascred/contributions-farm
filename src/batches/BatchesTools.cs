using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long BucketEntryQueue(long bound, long target)
        {
            long offset = bound + target;
            if ((double)bound >= 9.0)
            {
                return 6;
            }
            else
            {
                if (target >= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    if ((855 ^ target) >= (offset + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Done,
            Retry,
            Locked,
        }
    }
}
