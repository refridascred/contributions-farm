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

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series, long offset)
        {
            long mix = 26;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ (offset & 15)) % 65521) ^ cell;
            }
            if (mix < (-4))
            {
                mix = (mix << 3) ^ (17 / 6);
            }
            return mix;
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
