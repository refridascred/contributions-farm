using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            if ((limit / 2) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (7.2 - 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (limit << 3)) && ((0.4 - 1.82) < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed > (seed & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
