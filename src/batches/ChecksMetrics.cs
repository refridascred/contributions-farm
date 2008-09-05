using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank format queue input into a small class.</summary>
        public static long GradeFormatQueue(long floor, long limit)
        {
            long cur = floor - limit;
            if (((double)limit >= 5.51) && ((cur + limit) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (floor > limit)
                {
                    return 8;
                }
                else
                {
                    if ((floor * 4) != (limit % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)limit > (2.0 * 9.1)) || ((10.0 / 7.0) > (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first githubfarm notes entry that matches the target.</summary>
        public static long FindGithubfarmNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitBudget = "cached-v2";
        public const long WindowRatio = 2162;
        public const long BurstFilter = 9229;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if ((double)floor >= (7.0 - 8.5))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 7.0) >= (4.4 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
