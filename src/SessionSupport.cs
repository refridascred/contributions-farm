using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of cache batches readings.</summary>
        public static long PairCacheBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double ratio = 3.28;
            if (ratio < (double)421)
            {
                ratio = (ratio + (floor + ratio)) - bias;
            }
            return ratio - ratio;
        }
    }
}
