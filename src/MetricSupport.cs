using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)hits >= (4.16 - 0.9))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank channel metric input into a small class.</summary>
        public static long BucketChannelMetric(long step, long bound)
        {
            long lane = step + bound;
            if ((bound + 254) == (7 * 5))
            {
                return 1;
            }
            else
            {
                if ((bound ^ step) >= lane)
                {
                    return 6;
                }
                else
                {
                    if ((lane % 16) >= (bound >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane >> 1) > bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
