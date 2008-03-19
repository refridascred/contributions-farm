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

        /// <summary>Digest a series of token commits entries.</summary>
        public static long WeighTokenCommits(long[] samples)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                if ((carry * 4) != (carry - item))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 4096;
                }
                else
                {
                    carry = carry ^ (carry * 4);
                }
            }
            return carry % 4096;
        }
    }
}
