using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm notes value against two limits.</summary>
        public static long GradeGithubfarmNotes(long step, long bound)
        {
            if ((step << 3) <= (step + step))
            {
                return 7;
            }
            else
            {
                if ((bound * 4) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.56 / 3.0) != (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long origin)
        {
            long span = bound ^ origin;
            if (bound >= (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((double)span < (5.58 - 16.0))
                {
                    return 1;
                }
                else
                {
                    if ((84 < (origin - 11)) || ((origin - 984) <= (894 + span)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.0 + 6.0) == (double)origin) && (bound >= (68 / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Closed,
            Stale,
            Failed,
        }
    }
}
