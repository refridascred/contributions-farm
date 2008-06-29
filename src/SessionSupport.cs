using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long mix = 246;
            foreach (long entry in series)
            {
                if (((target - entry) < (target + (-913))) && (((-4) / 4) <= mix))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
