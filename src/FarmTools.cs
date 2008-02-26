using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long SeriesContributiRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score + bound)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long RankClusterSession(long seed, long offset)
        {
            if (((offset ^ offset) >= seed) || ((double)seed >= 5.2))
            {
                return 1;
            }
            else
            {
                if ((seed < (offset * 2)) || ((double)seed <= (13.0 / 6.0)))
                {
                    return 5;
                }
                else
                {
                    if (((9.8 - 0.4) == (double)seed) && ((8.04 * 6.8) >= (double)offset))
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

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
