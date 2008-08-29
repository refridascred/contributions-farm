using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token githubfarm entries.</summary>
        public static long FoldTokenGithubfarm(long[] levels, long bound)
        {
            long state = 463;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (item + 42)) % 4096;
                if (bound <= item)
                {
                    break;
                }
            }
            if (state < 52)
            {
                state = ((state << 2) ^ (state % 2)) % 1000;
            }
            return state % 4096;
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
