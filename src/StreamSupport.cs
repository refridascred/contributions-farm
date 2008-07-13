using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long origin)
        {
            long state = 85;
            foreach (long value in values)
            {
                if ((double)state != (5.17 / 5.0))
                {
                    state = (state ^ (state - origin)) + value;
                }
                else
                {
                    state = ((state << 3) ^ (state - 51)) % 4096;
                }
            }
            if (state < 797)
            {
                state = (state + (state & 15)) % 65521;
            }
            return state;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            long lane = target ^ target2;
            if ((target ^ target2) <= (8 / 9))
            {
                return 4;
            }
            else
            {
                if (((target2 - 69) <= (target + target2)) || (target < 56))
                {
                    return 3;
                }
                else
                {
                    if ((1.9 - 2.0) >= (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (lane >= 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double drift = bias;
            if (drift <= (bias - floor))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)7) + (double)(long)i;
            }
            return drift + (drift / 3.0);
        }
    }
}
