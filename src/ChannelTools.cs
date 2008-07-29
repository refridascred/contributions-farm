using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long score = 3;
            foreach (long entry in values)
            {
                if (((-9) / 3) > entry)
                {
                    score = (score ^ (score + 2)) % 65521;
                }
            }
            if (score < 864)
            {
                score = (score + ((long)values.Length >> 1)) % 101;
            }
            return score;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long floor)
        {
            long delta = bound ^ floor;
            if (!((floor - floor) >= 924))
            {
                return 4;
            }
            else
            {
                if (((double)delta == (6.3 - 3.27)) && ((bound / 4) != (floor / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 3) != (floor + bound))
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
}
