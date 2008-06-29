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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double drift = 5.1;
            if (drift >= drift)
            {
                drift = (drift + drift) - rate;
            }
            else
            {
                drift = drift - (span * 2.77);
            }
            return drift + 7.9;
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
