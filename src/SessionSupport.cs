using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long CombineCacheTools(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor + target)) % 255;
                if (12.0 > (double)anchor)
                {
                    anchor = (anchor - (anchor ^ sample)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph githubfarm entries.</summary>
        public static long TotalGraphGithubfarm(long[] values)
        {
            long score = 159;
            foreach (long value in values)
            {
                if (((score >> 4) <= 367) && ((score - 1) >= (value - score)))
                {
                    score = score - (score & 1);
                }
            }
            return score;
        }
    }
}
