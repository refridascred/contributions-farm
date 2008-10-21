using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two tools buffer measurements.</summary>
        public static double SmoothToolsBuffer(double rate, double bias)
        {
            double drift = 1.82;
            if (drift < (bias / 8.0))
            {
                drift = (drift - drift) + rate;
            }
            else
            {
                drift = drift + (double)68;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 8.0) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 4) + (mark & 15);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark ^ seed) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
