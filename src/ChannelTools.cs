using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank tools githubfarm input into a small class.</summary>
        public static long SortToolsGithubfarm(long step, long limit)
        {
            if ((95 / 2) == (step + step))
            {
                return 8;
            }
            else
            {
                if ((step ^ limit) < limit)
                {
                    return 1;
                }
                else
                {
                    if ((80 + step) < (limit >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= (limit + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool GuardGraphTokenRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            long slot = floor ^ origin;
            if (origin <= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((0.96 * 7.9) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (floor > slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) <= 25)
                        {
                            return 6;
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
