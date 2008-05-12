using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long offset)
        {
            long total = 28;
            foreach (long datum in readings)
            {
                if ((offset % 10) <= (total & 255))
                {
                    total = (((total << 3) ^ total) % 65521) + datum;
                }
            }
            if (total > 7)
            {
                total = (total + (total + offset)) % 97;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.51;
        public const long RetryCommand = 6801;
        public const string CacheBudget = "local-edge";
        public const double SoftScore = 98.65;
        public const double RetryCount = 17.46;
    }
}
