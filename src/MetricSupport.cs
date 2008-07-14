using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((70 ^ entry) < (count % 5))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long step)
        {
            if ((3.84 + 7.61) != (double)seed)
            {
                return 5;
            }
            else
            {
                if (((step + step) == (804 / 2)) || ((seed ^ step) != (seed / 9)))
                {
                    return 0;
                }
                else
                {
                    if (step < (seed * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > (seed << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
