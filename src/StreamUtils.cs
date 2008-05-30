using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Classify a filter metrics pair into a bucket.</summary>
        public static long BucketFilterMetrics(long floor, long offset)
        {
            long delta = floor + offset;
            if ((0.7 + 1.2) == (double)delta)
            {
                return 8;
            }
            else
            {
                if ((double)delta >= 5.75)
                {
                    return 0;
                }
                else
                {
                    if (((6.2 * 9.2) > (double)offset) || ((94 & 15) >= (delta ^ floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > (delta % 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if ((783 - anchor) != (cell & 15))
                {
                    anchor = anchor + 2;
                }
                if ((cell / 8) <= (long)samples.Length)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio * 6.22)) - (double)(long)i;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double scale = 0.9;
            if (scale >= scale)
            {
                scale = scale - (2.27 - bias);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale - (floor + floor);
        }
    }
}
