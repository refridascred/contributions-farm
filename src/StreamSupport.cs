using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < (bias + drift))
            {
                drift = drift - (bias2 * 0.94);
            }
            return drift - (14.0 - drift);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
