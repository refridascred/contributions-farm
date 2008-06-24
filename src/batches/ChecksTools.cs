using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long FoldLayoutCluster(long[] items, long target)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = (mark + (target - target)) % 255;
                if (entry >= ((-78) - target))
                {
                    mark = mark + (entry + 84);
                }
            }
            return mark % 1000;
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
