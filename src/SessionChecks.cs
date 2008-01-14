using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate contributi window readings against a bound.</summary>
        public static bool CheckContributiWindowLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout farm pair into a bucket.</summary>
        public static long SortLayoutFarm(long offset, long origin)
        {
            if (offset > (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((588 + offset) < (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 5) <= (offset << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 2) >= (matches / 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio / 2.0)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
