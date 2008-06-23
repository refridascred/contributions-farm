using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset ^ state) >= ((long)i - state))
                {
                    state = ((state << 2) ^ state) % 97;
                }
                if ((5 << 3) < (state ^ 26))
                {
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (offset ^ state)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((target & 15) < (reading * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long bound)
        {
            if (((166 << 3) != (origin + 432)) || ((origin - bound) != (origin % 3)))
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 97) == (bound << 2)) || ((double)bound == (2.55 / 7.0)))
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
}
