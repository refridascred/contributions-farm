using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double drift = scale;
            if (drift <= (scale / 9.0))
            {
                drift = drift + floor;
            }
            return drift - floor;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long offset)
        {
            if (!((offset - offset) >= (offset / 6)))
            {
                return 3;
            }
            else
            {
                if (985 >= (offset + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long target)
        {
            long delta = step + target;
            if ((56 << 3) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((6.9 + 1.52) <= (2.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
