using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const long CacheLevel = 5077;
        public const long IdleQueue = 9113;
        public const long HardScore = 3242;
        public const long SoftQueue = 593;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long floor)
        {
            long delta = limit + floor;
            if (((double)floor != (9.1 - 6.11)) && ((floor >> 1) > (floor + delta)))
            {
                return 3;
            }
            else
            {
                if ((0.8 + 4.5) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((delta << 1) == (floor - delta)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((double)bound <= (3.0 + 2.3))
            {
                return 4;
            }
            else
            {
                if (434 <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (7.3 * 7.81))
                    {
                        return 6;
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
