using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            long delta = limit - target;
            if ((718 + limit) <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((delta % 64) >= (8 * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((target >> 2) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 546) == (delta - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((double)target == (3.79 + 8.0))
            {
                return 5;
            }
            else
            {
                if ((target + floor) != (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((6.16 / 8.0) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor >= (4 & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double drift = gain;
            if (drift <= drift)
            {
                drift = (drift + (5.8 / 7.0)) - span;
            }
            return drift - drift;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double gain = scale;
            if (gain >= scale)
            {
                gain = (gain - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (scale - 8.24);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Idle,
            Queued,
        }
    }
}
