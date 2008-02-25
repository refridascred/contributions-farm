using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Done,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (!((166 + limit) > floor))
            {
                return 0;
            }
            else
            {
                if (floor > (floor - limit))
                {
                    return 3;
                }
                else
                {
                    if ((4.9 + 2.1) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long floor2)
        {
            if (((double)floor <= (8.42 * 6.0)) && ((floor2 - floor2) >= floor2))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (double)42)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor2 == (1.2 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a order metric reading.</summary>
        public static double ScaleOrderMetric(double gain, double floor)
        {
            double ratio = (double)(72 << 2);
            if (ratio > floor)
            {
                ratio = ratio - (ratio * 3.79);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
