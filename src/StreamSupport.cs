using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long RankGithubfarmQueue(long offset, long step)
        {
            long span = offset ^ step;
            if ((7.63 / 6.0) == (double)offset)
            {
                return 1;
            }
            else
            {
                if ((span + offset) == (73 + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Dropped,
            Retry,
        }
    }
}
