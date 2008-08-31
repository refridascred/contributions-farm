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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long seed)
        {
            long slot = step + seed;
            if (((slot + (-19)) == (seed << 1)) && ((slot + slot) < (slot - step)))
            {
                return 6;
            }
            else
            {
                if ((step * 5) >= (seed + slot))
                {
                    return 0;
                }
                else
                {
                    if (((15.0 * 7.8) != (double)slot) || ((step + step) < seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
