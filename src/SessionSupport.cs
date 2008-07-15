using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count command layout pairs that satisfy a relation.</summary>
        public static long PairCommandLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long SortGithubfarmStats(long step, long step2)
        {
            if (!((15.0 * 2.53) >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((step2 * 2) >= (4 ^ step2))
                {
                    return 7;
                }
                else
                {
                    if ((0.25 + 8.17) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3225;
        public const long BurstCluster = 1810;
        public const string BatchInterval = "alpha";
        public const long MaxCluster = 9051;
        public const long SoftInterval = 7252;
    }
}
