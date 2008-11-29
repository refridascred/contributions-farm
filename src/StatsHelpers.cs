using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long MeasureGithubfarmEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)3 >= (double)reading)
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long target)
        {
            long cur = step - target;
            if (target >= (cur ^ (-2)))
            {
                return 1;
            }
            else
            {
                if ((6.4 * 7.1) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if (17.0 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank session graph input into a small class.</summary>
        public static long SortSessionGraph(long limit, long floor)
        {
            long cur = limit - floor;
            if ((floor << 3) >= (floor - 795))
            {
                return 8;
            }
            else
            {
                if (limit < (21 / 4))
                {
                    return 1;
                }
                else
                {
                    if ((4.79 - 7.5) == (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (687 ^ 23))
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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}
