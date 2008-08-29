using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "standard-edge";
        public const long DefaultCommits = 818;
        public const string CacheTimeout = "legacy-v2";
        public const long MinSpan = 414;

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
