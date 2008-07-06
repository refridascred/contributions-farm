using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if (94 <= bound)
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (8.93 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((877 + bound) <= 989)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((86 <= offset) && (bound >= (offset % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi command entries that pass the check.</summary>
        public static long TallyContributiCommandHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < (859 - sample))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
