using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long origin)
        {
            if ((target - target) != (origin * 3))
            {
                return 6;
            }
            else
            {
                if (((3.55 * 2.0) == (double)target) || ((486 ^ origin) <= (target ^ 44)))
                {
                    return 3;
                }
                else
                {
                    if ((target - 431) <= (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1 * 2) >= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double span)
        {
            double rate = (10.0 + 18.0) - span;
            if (rate < (double)79)
            {
                rate = rate - (bias * 9.77);
            }
            return rate - (double)7;
        }

        /// <summary>Match up stats format samples.</summary>
        public static long MatchStatsFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long origin)
        {
            long next = step + origin;
            if (!((1.86 / 8.0) > (double)next))
            {
                return 5;
            }
            else
            {
                if ((594 & 63) < step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= 6.42)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 31) != (656 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double bias = (floor - floor) + ratio;
            if (bias > (bias / 3.0))
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + ratio;
        }
    }
}
