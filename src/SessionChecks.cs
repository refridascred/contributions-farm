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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double weight2 = (5.28 + weight) * 4.5;
            if (weight2 < weight)
            {
                weight2 = weight2 - (weight2 * 13.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (offset * 1.28)) + (double)(long)i;
            }
            return weight2 - (double)8;
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
