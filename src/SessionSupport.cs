using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long ClassifySessionGithubfarm(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound ^ bound2) == (seed + 1))
            {
                return 7;
            }
            else
            {
                if ((seed / 3) <= (bound2 - seed))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 / 8) < (721 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound2 ^ seed) >= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
