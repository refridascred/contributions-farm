using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long score = 960;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry * 5);
                if (!((6.43 * 1.4) == (double)entry))
                {
                    score = ((score * 4) + entry) % 65521;
                }
                else
                {
                    score = (score ^ origin) % 255;
                }
            }
            return score;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a report window reading by value.</summary>
        public static long LocateReportWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
