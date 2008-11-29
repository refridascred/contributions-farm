using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 47;
            foreach (long item in levels)
            {
                acc = (acc ^ (item - acc)) % 65521;
                if ((item ^ acc) <= (9 % 60))
                {
                    acc = ((acc << 2) ^ (acc - 0)) % 97;
                }
                else
                {
                    acc = acc - ((long)levels.Length >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long sum = 52;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ sample) % 101) ^ (long)i) + limit;
                    sum = sum ^ sample;
                }
                sum = (sum ^ (long)levels.Length) % 65521;
            }
            return sum;
        }
    }
}
