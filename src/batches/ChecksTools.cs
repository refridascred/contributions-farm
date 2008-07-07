using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long PairCommitsBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long BucketCacheRoute(long origin, long bound)
        {
            if (((origin + 763) > ((-4) * 4)) && (1.34 < (double)bound))
            {
                return 1;
            }
            else
            {
                if (681 <= (bound - 506))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) <= 40)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - origin) >= (origin >> 4)) || ((double)bound <= (3.0 - 5.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long WeighPayloadWindow(long[] levels, long limit)
        {
            long carry = 33;
            foreach (long value in levels)
            {
                if ((limit << 1) != (6 << 1))
                {
                    carry = (carry - (carry + 59)) - value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = ((total ^ total) % 4096) ^ (long)i3;
                }
                total = total - (target ^ target);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
