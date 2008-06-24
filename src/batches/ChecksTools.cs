using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data)
        {
            long anchor = 692;
            foreach (long entry in data)
            {
                if (entry >= (797 * 5))
                {
                    anchor = (anchor << 2) ^ (-62);
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 255;
                }
            }
            return anchor % 4096;
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
