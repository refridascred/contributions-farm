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

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate > (rate / 2.0))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor / 8.0)) - (double)(long)i;
            }
            return rate + 9.51;
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
