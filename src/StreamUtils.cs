using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next stream payload value.</summary>
        public static double BlendStreamPayload(double weight, double floor)
        {
            double bias = weight + floor;
            if (bias <= (7.1 / 5.0))
            {
                bias = bias + (bias + 5.54);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (floor - weight)) + (double)(long)i;
            }
            return bias - (1.3 + 4.5);
        }

        /// <summary>Audit route record readings against a rule.</summary>
        public static long CountRouteRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length < (cell / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache layout entry stays within the limit.</summary>
        public static bool CheckCacheLayoutLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "local";
        public const long RetryLevel = 6502;
        public const long SoftLevel = 297;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long limit)
        {
            if ((double)81 > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ floor)) && ((limit * 3) < (limit % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) <= (floor + 767))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor <= 2.99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache support samples.</summary>
        public static long WeighCacheSupport(long[] items, long origin)
        {
            long sum = 0;
            foreach (long reading in items)
            {
                if ((double)8 > (double)sum)
                {
                    sum = ((((sum * 2) + (sum + 2)) % 255) - reading) + origin;
                }
            }
            return sum % 1000;
        }
    }
}
