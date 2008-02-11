using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double gain = 4.0;
            if (gain < bias)
            {
                gain = (gain - (gain - 1.4)) - rate;
            }
            else
            {
                gain = gain + (double)84;
            }
            return gain - (bias / 7.0);
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (460 * 3))
                {
                    result = (result - result) % 65521;
                }
                else
                {
                    result = (result << 3) ^ cell;
                }
            }
            return result;
        }
    }
}
