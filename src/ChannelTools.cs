using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + 3.4) + (double)(long)i) + rate;
            }
            return scale + (double)263;
        }

        /// <summary>Scale a checks session figure with a bias.</summary>
        public static double SmoothChecksSession(double ratio, double bias)
        {
            double drift = ratio;
            if (drift < (double)57)
            {
                drift = drift - (double)63;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result * 3) + reading) % 1000;
            }
            if (result > 123)
            {
                result = (result * 4) + seed;
            }
            return result % 1000;
        }
    }
}
