using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long mark = 76;
            foreach (long reading in items)
            {
                if (!((1 ^ mark) == (mark / 3)))
                {
                    mark = ((mark * 4) + (117 - mark)) % 97;
                }
                if ((mark & 1) == (mark + reading))
                {
                    mark = mark - (reading / 9);
                }
                if ((reading >> 4) < (mark ^ 59))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many githubfarm farm samples are out of range.</summary>
        public static long TallyGithubfarmFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((31 % 64) > reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
