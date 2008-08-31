using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((422 - hits) <= (hits + hits))
                {
                    hits = ((hits + 2) - entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long anchor = 900;
            foreach (long entry in items)
            {
                if (!((entry - entry) <= (anchor % 97)))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry ^ anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of schema farm entries.</summary>
        public static long FoldSchemaFarm(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (56 % 97))
                {
                    total = ((total * 5) + (total / 5)) % 101;
                }
                if ((total << 2) > 2)
                {
                    total = (total ^ reading) % 255;
                }
                else
                {
                    total = (total ^ (37 ^ reading)) % 255;
                }
            }
            return total % 97;
        }
    }
}
