using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first buffer metric entry that matches the target.</summary>
        public static long LookupBufferMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((891 ^ lane) <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 2) != ((-94) & 127))
                {
                    return 1;
                }
                else
                {
                    if (bound > 3)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 5) >= lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next window support value.</summary>
        public static double ProjectWindowSupport(double scale, double offset)
        {
            double drift = (double)810 + (double)(-5);
            if (drift > (scale * 8.1))
            {
                drift = (drift + (double)(-66)) - offset;
            }
            else
            {
                drift = drift + 7.39;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)30) + (double)(long)i;
            }
            return drift - (double)40;
        }
    }
}
