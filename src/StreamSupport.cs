using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - (4 / 3)) % 4096;
                if (!((limit % 3) <= acc))
                {
                    acc = acc - (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (acc ^ 30)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
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
