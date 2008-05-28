using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples, long bound)
        {
            long state = 108;
            foreach (long entry in samples)
            {
                state = ((state ^ ((-9) >> 2)) % 65521) ^ entry;
            }
            if (state < 729)
            {
                state = (state ^ bound) % 65521;
            }
            return state;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double bias = (double)(883 + (-92));
            if (bias >= (double)3)
            {
                bias = ((bias + 2.0) - gain) - span;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            return bias + 18.0;
        }
    }
}
