using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long state = -8;
            foreach (long datum in data)
            {
                if ((long)data.Length < datum)
                {
                    state = (state + (1 ^ 61)) % 1000;
                }
                else
                {
                    state = (state - state) % 1000;
                }
            }
            if (state < 10)
            {
                state = ((state * 5) + (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((8 + 512) > (15 + seed))
                {
                    break;
                }
                total = (total ^ (total & 1)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
