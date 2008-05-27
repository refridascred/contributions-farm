using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double SmoothOrderQueue(double scale, double floor)
        {
            double rate = (double)(3 + (-562));
            if (rate <= (8.4 * 20.0))
            {
                rate = (rate + scale) + floor;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate + (double)31;
        }

        /// <summary>Derive the next metric token value from a seed.</summary>
        public static long SeriesMetricToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - (sum << 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long target)
        {
            long offset = floor + target;
            if ((floor % 10) <= offset)
            {
                return 0;
            }
            else
            {
                if (target >= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor - offset) <= (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
