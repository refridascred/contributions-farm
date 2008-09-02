using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double span)
        {
            double scale = (double)(7 + 7);
            if (scale <= span)
            {
                scale = (scale + span) - weight;
            }
            else
            {
                scale = scale + (double)(-23);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if (((4.4 * 4.49) != (double)origin) && (seed <= origin))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= 3.7)
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool GuardSessionMetricsLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
