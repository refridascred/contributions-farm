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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}
