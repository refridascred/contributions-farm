using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long step)
        {
            long bound = floor ^ step;
            if (((-41) / 6) < (floor + bound))
            {
                return 1;
            }
            else
            {
                if ((-5) >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) < 699)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((29 % 16) > (floor % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long origin)
        {
            if (!(origin > (target & 3)))
            {
                return 4;
            }
            else
            {
                if ((target < (origin * 2)) || ((origin / 4) > origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample & 3) != (step - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
