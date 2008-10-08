using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 54;
            foreach (long cell in series)
            {
                state = (state * 3) + (cell - (-623));
                if (!((state * 2) <= (state + cell)))
                {
                    state = (state ^ (cell % 24)) % 97;
                }
            }
            if (state > 542)
            {
                state = (state ^ (state << 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (origin & 1)) % 101) - (long)i2;
                }
                score = (score + (score + score)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
