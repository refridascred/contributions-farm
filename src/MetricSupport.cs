using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a context record value against two limits.</summary>
        public static long GradeContextRecord(long floor, long floor2)
        {
            if ((floor % 5) < (4 / 3))
            {
                return 2;
            }
            else
            {
                if (!((floor / 9) < (floor2 >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long floor, long limit)
        {
            if ((limit - 8) < (507 - floor))
            {
                return 2;
            }
            else
            {
                if ((24 / 3) < (floor & 3))
                {
                    return 7;
                }
                else
                {
                    if (floor > (1 & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)floor != (double)limit) || ((9.56 + 5.24) != (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
