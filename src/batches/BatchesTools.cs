using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long origin, long step)
        {
            if ((step << 3) >= (278 / 4))
            {
                return 0;
            }
            else
            {
                if (!((double)origin < 8.0))
                {
                    return 2;
                }
                else
                {
                    if (!((step & 127) >= (step % 60)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Active,
            Dropped,
        }
    }
}
