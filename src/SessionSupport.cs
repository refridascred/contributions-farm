using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((acc + bound) >= (-271)) || ((double)(long)i <= (19.0 * 8.0)))
                {
                    acc = ((acc << 2) ^ (acc - (long)i)) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = (acc * 3) + (172 & 15);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = (double)(611 ^ 402);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.68) + (double)(long)i) + weight;
            }
            return scale - span;
        }
    }
}
