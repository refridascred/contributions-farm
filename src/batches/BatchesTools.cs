using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order counter value from a seed.</summary>
        public static long IterateOrderCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long sum = 91;
            foreach (long item in series)
            {
                sum = ((sum * 3) + 40) % 101;
                if (item < (517 >> 3))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = sum + seed;
            }
            return sum % 65521;
        }
    }
}
