using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits * 4) != (hits * 3))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank format githubfarm input into a small class.</summary>
        public static long BucketFormatGithubfarm(long target, long bound)
        {
            long next = target - bound;
            if ((target & 63) < target)
            {
                return 0;
            }
            else
            {
                if (((813 - next) == (next + target)) || (719 > (bound ^ 0)))
                {
                    return 3;
                }
                else
                {
                    if (38 < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(next >= (next ^ 29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long offset)
        {
            long offset2 = limit + offset;
            if (((-37) > (limit / 9)) || ((double)offset2 == (9.9 * 3.0)))
            {
                return 3;
            }
            else
            {
                if (((double)offset2 <= 1.0) && ((limit - offset) != (offset2 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((limit < (offset2 % 60)) || ((offset2 >> 1) >= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
