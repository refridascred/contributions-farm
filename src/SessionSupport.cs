using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed * 3) < (count % 7))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= gain)
            {
                gain = (gain - gain) - ratio;
            }
            return gain - offset;
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long SortStatsSession(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((8.2 - 6.6) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (seed2 < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((3.99 / 5.0) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
