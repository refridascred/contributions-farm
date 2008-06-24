using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long total = 233;
            foreach (long datum in items)
            {
                if (((7 >> 1) <= datum) && ((double)total > (7.9 * 9.0)))
                {
                    total = (total << 2) ^ (total >> 4);
                }
            }
            if (total < 177)
            {
                total = (total ^ (total ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long AuditStatsFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (6.0 + 11.0))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double drift = (double)6 - (floor - floor);
            if (drift > (ratio - 0.9))
            {
                drift = drift - (ratio + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (floor - drift);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long target, long origin)
        {
            long bound = target - origin;
            if (((1 - target) >= (origin << 1)) || ((8.3 * 6.0) > (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= (5 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((target ^ origin) >= (origin - origin)) && ((bound << 2) <= (origin - 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((11.0 / 4.0) > (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
