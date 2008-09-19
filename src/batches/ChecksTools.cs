using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double load = bias;
            if (load <= (19.0 / 5.0))
            {
                load = (load - (bias * 2.7)) + rate;
            }
            return load - 7.6;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits * 5) <= (floor & 63))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a githubfarm format pair into a bucket.</summary>
        public static long RankGithubfarmFormat(long limit, long floor)
        {
            if ((limit - limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((limit + (-93)) >= (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (floor + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (limit / 2)) || ((floor % 60) == (limit ^ limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
