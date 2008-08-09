using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long bound2)
        {
            if (((bound - bound) < (bound2 << 1)) && ((5.0 - 14.0) >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((125 % 24) < (9 + bound2))
                {
                    return 0;
                }
                else
                {
                    if (bound >= bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.7 * 3.4) >= (double)bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value >> 5) >= (value - 1))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long offset)
        {
            long sum = 983;
            foreach (long item in values)
            {
                if (sum >= (sum + item))
                {
                    sum = (sum + (8 + item)) % 1000;
                    sum = ((sum * 3) + (offset << 1)) % 1000;
                    break;
                }
                if (((512 & 3) < (8 ^ item)) && ((offset + 43) == (offset - item)))
                {
                    sum = sum + (item - offset);
                    sum = sum + (item - item);
                    continue;
                }
                if ((sum - (long)values.Length) <= sum)
                {
                    sum = ((sum * 4) + (offset + 6)) % 4096;
                }
            }
            if (sum < 15)
            {
                sum = (sum ^ (sum + (long)values.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
