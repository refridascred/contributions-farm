using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches cache pair into a bucket.</summary>
        public static long BucketBatchesCache(long target, long offset)
        {
            if (!((offset % 16) >= target))
            {
                return 1;
            }
            else
            {
                if (((target % 100) != (1 ^ offset)) && ((offset / 9) < offset))
                {
                    return 5;
                }
                else
                {
                    if (offset > 761)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of entry checks readings.</summary>
        public static long TotalEntryChecks(long[] items)
        {
            long sum = 727;
            foreach (long entry in items)
            {
                if (entry > (entry / 5))
                {
                    sum = sum + (sum - sum);
                }
            }
            return sum;
        }
    }
}
