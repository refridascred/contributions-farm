using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev / 3) < (floor % 16)) && ((1.9 - 20.0) <= (double)prev))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) > floor)
                {
                    return 2;
                }
                else
                {
                    if ((5.6 + 10.0) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (713 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 6.4) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (947 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = (mix + mix) - step;
                mix = (mix * 4) + (reading + reading);
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double span)
        {
            double bias = (weight + 7.0) * 8.0;
            if (bias < weight)
            {
                bias = bias + (span / 3.0);
            }
            return bias - 12.0;
        }
    }
}
