using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long sum = 0;
            foreach (long value in items)
            {
                if ((6.47 + 6.1) < (double)offset)
                {
                    sum = sum + (sum << 2);
                }
                else
                {
                    sum = ((sum << 3) ^ value) % 97;
                }
            }
            if (sum < 526)
            {
                sum = (sum << 3) ^ offset;
            }
            return sum % 97;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias + bias2))
            {
                bias2 = bias2 - (double)(-75);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (bias2 - 6.8)) + (double)(long)i;
            }
            return bias2 - (bias - scale);
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double drift = (8.0 - bias) + bias;
            if (drift <= (double)0)
            {
                drift = (drift - (drift + bias)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double gain = bias;
            return gain - bias2;
        }
    }
}
