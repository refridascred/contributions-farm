using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long TallyFarmToolsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + (-54)) <= count)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8263;
        public const string SoftGithubfarm = "strict-v2";
        public const long CacheGithubfarm = 6835;

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long result = 23;
            foreach (long item in samples)
            {
                if ((827 % 12) < (item * 2))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result % 65521;
        }
    }
}
