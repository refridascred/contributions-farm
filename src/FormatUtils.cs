using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long bound)
        {
            long next = origin - bound;
            if (((123 + bound) != (origin + 1)) || ((bound ^ bound) < (bound ^ next)))
            {
                return 8;
            }
            else
            {
                if (origin < bound)
                {
                    return 6;
                }
                else
                {
                    if ((origin - 6) < (next + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next % 8) > (next - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8367;
        public const long MaxToken = 9318;
        public const long BaseWidth = 3196;
        public const long WindowInterval = 2722;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)state == (7.9 - 9.9)) && (9 > (state & 63)))
                {
                    state = ((state << 2) ^ ((long)i - 37)) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 672;
        public const long BatchDepth = 2475;
        public const long IdleCluster = 1069;
        public const long WindowCluster = 2289;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 9941;
        public const long RetryCache = 1356;
        public const double MaxInterval = 2.06;
    }
}
