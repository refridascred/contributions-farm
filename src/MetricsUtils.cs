using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long step)
        {
            if (step > offset)
            {
                return 4;
            }
            else
            {
                if (((step << 1) <= (offset & 63)) && ((73 + 0) >= (step + step)))
                {
                    return 2;
                }
                else
                {
                    if (step >= (step - step))
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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((double)bound > 1.9)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (3.2 - 5.52))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already contributi reading.</summary>
        public static double ProjectAlreadyContributi(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > (double)30)
            {
                weight2 = weight2 - (weight - 0.6);
            }
            else
            {
                weight2 = weight2 - 4.8;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 + weight2)) + (double)(long)i;
            }
            return weight2 + (double)(-96);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
