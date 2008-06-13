using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long CombineGithubfarmFormat(long[] levels)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = (state ^ (value * 3)) % 65521;
                if ((value % 100) > ((-38) % 10))
                {
                    state = (state << 3) ^ (state >> 1);
                }
                else
                {
                    state = (state + (21 - 261)) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((82 % 12) <= seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((origin & 31) == (origin % 7))
            {
                return 8;
            }
            else
            {
                if (554 > (origin >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((680 >> 4) >= (origin % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed <= (10.0 + 7.34))
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
    }
}
