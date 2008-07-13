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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
