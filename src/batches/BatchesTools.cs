using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((double)mix == (double)seed) && ((1.0 - 9.04) >= (double)(long)i))
                {
                    mix = mix - (mix - mix);
                    continue;
                }
                if ((double)mix == (5.9 * 9.13))
                {
                    mix = ((mix * 2) + ((long)i * 4)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
