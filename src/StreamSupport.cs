using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a graph already value against two limits.</summary>
        public static long RankGraphAlready(long origin, long step)
        {
            if ((3.5 * 14.0) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((step - 3) < (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((5.9 - 5.0) >= (double)origin) || ((15.0 - 3.9) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= 3.1)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long score = 588;
            foreach (long item in series)
            {
                if ((3.6 / 3.0) == (double)item)
                {
                    score = score ^ (score >> 2);
                }
                if ((18.0 * 14.0) > (double)score)
                {
                    break;
                }
            }
            return score;
        }
    }
}
