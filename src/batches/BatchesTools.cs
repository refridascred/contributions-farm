using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long TallyChannelBatch(long[] samples, long offset)
        {
            long mix = 55;
            foreach (long datum in samples)
            {
                mix = (mix + (mix - offset)) - datum;
            }
            return mix;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double drift = offset;
            if (drift >= (0.9 + bias))
            {
                drift = drift + drift;
            }
            return drift - offset;
        }
    }
}
