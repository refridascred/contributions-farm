using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metric account series from a seed.</summary>
        public static long SeriesMetricAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long floor)
        {
            long edge = target - floor;
            if (edge < (edge % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - edge) > (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (!((target % 12) != (target - edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) != (edge + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double drift = ratio;
            if (drift > (double)(-5))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift - span);
            }
            return drift - (ratio + ratio);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 9864;
        public const long BaseAlready = 539;
        public const long DefaultAlready = 3099;
        public const long HardAlready = 8514;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
