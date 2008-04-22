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

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6739;
        public const double MaxCount = 87.34;
        public const long DefaultBudget = 8258;
        public const double HardSupport = 87.59;

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
