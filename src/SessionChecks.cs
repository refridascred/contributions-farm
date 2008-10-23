using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long target)
        {
            long offset = floor - target;
            if ((target < (57 - target)) && ((target + target) > (offset % 3)))
            {
                return 4;
            }
            else
            {
                if (51 >= floor)
                {
                    return 6;
                }
                else
                {
                    if (((offset << 2) == (target % 16)) || ((floor + target) < 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 - 7.0) != (double)count)
                {
                    count = ((count + 1) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double bias)
        {
            double gain = bias;
            if (gain < 7.0)
            {
                gain = (gain - gain) + weight;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 7.2) + (double)(long)i;
            }
            return gain + (gain / 9.0);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell % 3))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
