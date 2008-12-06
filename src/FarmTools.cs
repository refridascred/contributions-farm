using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series)
        {
            long mix = 55;
            foreach (long item in series)
            {
                mix = ((mix - (mix + mix)) % 255) - item;
            }
            if (mix < 561)
            {
                mix = mix - (mix >> 2);
            }
            return mix % 97;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Dropped,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double drift = (double)(281 + 2);
            if (drift >= bias)
            {
                drift = (drift + (drift / 6.0)) - span;
            }
            else
            {
                drift = drift - (double)2;
            }
            return drift + bias;
        }
    }
}
