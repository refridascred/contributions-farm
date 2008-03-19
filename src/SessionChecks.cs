using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples)
        {
            long total = 37;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ entry) > (entry + total))
                {
                    total = total - entry;
                }
                else
                {
                    total = (total + (2 - entry)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long mark = 711;
            foreach (long entry in values)
            {
                if ((mark & 255) == (mark << 2))
                {
                    mark = (mark ^ 292) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ entry;
                }
            }
            return mark % 1000;
        }
    }
}
