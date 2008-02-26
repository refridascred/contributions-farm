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

        /// <summary>Classify a editor account pair into a bucket.</summary>
        public static long RankEditorAccount(long target, long step)
        {
            if (target <= (target ^ step))
            {
                return 6;
            }
            else
            {
                if (((step / 6) <= step) && (target >= ((-370) << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((9 - step) >= (step + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step < (6.1 - 7.5)) && ((double)target <= (5.0 - 3.5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
