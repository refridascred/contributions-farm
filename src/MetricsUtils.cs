using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((0.8 > (double)target) && (target < (seen << 1)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (limit2 > (5 * 3))
            {
                return 3;
            }
            else
            {
                if (355 > (prev * 2))
                {
                    return 5;
                }
                else
                {
                    if ((prev + prev) != (limit2 & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit2 >= (double)prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
