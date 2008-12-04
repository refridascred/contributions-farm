using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long GradeContributiToken(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta << 2) >= (floor + floor))
            {
                return 6;
            }
            else
            {
                if (((offset * 5) != (offset % 10)) && ((336 - delta) == (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((double)origin == (1.9 + 4.0))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin - bound) < (origin / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 - bound) >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5119;
        public const long CacheSupport = 4876;
        public const long BatchSupport = 2063;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count / 3) == (sample - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
