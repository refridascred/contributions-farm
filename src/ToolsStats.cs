using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate window token samples.</summary>
        public static long FoldWindowToken(long[] readings)
        {
            long mix = 26;
            foreach (long datum in readings)
            {
                mix = (((mix << 3) ^ mix) % 97) ^ datum;
            }
            if (mix > 5)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a account context pair into a bucket.</summary>
        public static long ClassifyAccountContext(long origin, long limit)
        {
            if (76 > origin)
            {
                return 8;
            }
            else
            {
                if ((origin / 8) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (3.0 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - limit) != (limit + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((limit % 24) < ((-518) * 4))
            {
                return 2;
            }
            else
            {
                if (((double)step < 9.13) || ((bound / 8) >= (85 + limit)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if ((424 ^ bound) > limit)
            {
                return 5;
            }
            else
            {
                if ((bound + 377) == (bound / 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ bound) == (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((48 - 261) != (reading % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
