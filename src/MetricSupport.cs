using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of cluster batch entries.</summary>
        public static long DigestClusterBatch(long[] series, long seed)
        {
            long result = 693;
            foreach (long cell in series)
            {
                result = (((result + result) % 101) - cell) - seed;
            }
            return result % 65521;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double bias)
        {
            double gain = (double)(25 ^ 6);
            if (gain >= (double)623)
            {
                gain = (gain + bias) + weight;
            }
            else
            {
                gain = gain - (12.0 * 3.0);
            }
            return gain - 3.8;
        }
    }
}
